using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple.Controls;
using Simple.Objects.Controls;
using DemoApp.Objects;
using Simple.Objects;

namespace DemoApp
{
	[EditPanelInfo(typeof(UserGroup))]
	public partial class EditPanelUserGroup : EditPanelNameDescription
    {
		private int columnFirstNameIndex, columnLastNameIndex, columnUsernameIndex;

		public EditPanelUserGroup()
        {
            InitializeComponent();
        }

        protected override void OnInitializeEditors()
        {
            base.OnInitializeEditors();

			this.EditorBindings.Register(this.editorName.Properties, typeof(UserGroup), UserGroupModel.PropertyModel.Name);
			this.EditorBindings.Register(this.editorDescription.Properties, typeof(UserGroup), UserGroupModel.PropertyModel.Description);

            this.columnFirstNameIndex = this.graphControllerAdministratorMembers.Columns.Add(new GraphColumn(UserModel.PropertyModel.FirstName.PropertyName));
			this.columnLastNameIndex  = this.graphControllerAdministratorMembers.Columns.Add(new GraphColumn(UserModel.PropertyModel.LastName.PropertyName));
			this.columnUsernameIndex  = this.graphControllerAdministratorMembers.Columns.Add(new GraphColumn(UserModel.PropertyModel.Username.PropertyName));

			this.graphControllerAdministratorMembers.ObjectManager = this.ObjectManager;
			this.graphControllerAdministratorMembers.SetGraphColumnBindingPolicy(this.columnFirstNameIndex, Simple.Objects.FolderModel.PropertyModel.Name);
			this.graphControllerAdministratorMembers.BeforeCheckGraphElement += GraphControllerAdministratorMembers_BeforeCheckGraphElement;
            this.graphControllerAdministratorMembers.Bind();
        }

		//protected override void OnInitializeNetworkGroupMembership()
		//{
		//	this.graphControllerNetworkGroupMembership.GraphKey = GraphKey.NetworkPolicy;
		//	this.columnNameIndex = this.graphControllerNetworkGroupMembership.Columns.Add(new GraphColumn(NetworkModel.PropertyModel.Name.PropertyName));
		//	this.columnIpAddressIndex = this.graphControllerNetworkGroupMembership.Columns.Add(new GraphColumn(NetworkModel.PropertyModel.IpAddressText.PropertyName, "IP Address"));
		//	this.columnIpSubnetMaskIndex = this.graphControllerNetworkGroupMembership.Columns.Add(new GraphColumn(NetworkModel.PropertyModel.SubnetMaskPrefix.PropertyName, "Subnet Musk"));
		//	this.columnVlanIdIndex = this.graphControllerNetworkGroupMembership.Columns.Add(new GraphColumn(NetworkModel.PropertyModel.VlanId.PropertyName, "VLAN ID"));
		//	this.graphControllerNetworkGroupMembership.Bind();
		//}


		private void GraphControllerAdministratorMembers_BeforeCheckGraphElement(object sender, CheckGraphElementEventArgs e)
		{
			if (this.BindingObject is UserGroup && this.BindingObject.Id == 1 && e.GraphElement?.SimpleObject is User && e.GraphElement.SimpleObject.Id == 1)
				e.CanCheck = false; // prevent adding/removing System Admin group membership for Administrators groups
		}

		protected override void OnBindingObjectChange(BindingObjectEventArgs e)
		{
			bool disableEdit = e.BindingObject is UserGroup userGroup && userGroup.Id == 1;

			this.editorName.Enabled = !disableEdit;
			
			base.OnBindingObjectChange(e);
		}
	}
}
