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
using Simple.Security;

namespace DemoApp
{
	[EditPanelInfo(typeof(User))]
	public partial class EditPanelUser : EditPanelDescription
	{
		public EditPanelUser()
		{
			InitializeComponent();
		}

		protected override void OnInitializeEditors()
		{
			base.OnInitializeEditors();
			this.EditorBindings.Register(this.editorFirstName.Properties, typeof(User), UserModel.PropertyModel.FirstName);
			this.EditorBindings.Register(this.editorLastName.Properties, typeof(User), UserModel.PropertyModel.LastName);
			this.EditorBindings.Register(this.editorUsername.Properties, typeof(User), UserModel.PropertyModel.Username);
			//this.EditorBindings.Register(this.editorPassword.Properties,	typeof(User), UserModel.PropertyModel.PasswordHash);
			this.EditorBindings.Register(this.editorLocation.Properties, typeof(User), UserModel.PropertyModel.Location);
			this.EditorBindings.Register(this.editorDescription.Properties, typeof(User), UserModel.PropertyModel.Description);

			this.graphControllerAdministratorGroupMembership.ObjectManager = this.ObjectManager;
			this.graphControllerAdministratorGroupMembership.Columns.Add(new GraphColumn(UserGroupModel.PropertyModel.Name.PropertyName));
			this.graphControllerAdministratorGroupMembership.Columns.Add(new GraphColumn(UserGroupModel.PropertyModel.Description.PropertyName));
			this.graphControllerAdministratorGroupMembership.BeforeCheckGraphElement += GraphControllerAdministratorGroupMembership_BeforeCheckGraphElement;
			this.graphControllerAdministratorGroupMembership.Bind();
		}

		protected override void OnBindingObjectChange(BindingObjectEventArgs e)
		{
			base.OnBindingObjectChange(e);

			bool disableEdit = true;

			if (e.BindingObject is User user)
			{
				disableEdit = user.Id == 1;

				this.editorFirstName.Enabled = !disableEdit;
				this.editorLastName.Enabled = !disableEdit;
				this.editorUsername.Enabled = !disableEdit;
				this.checkEditAccountIsDisabled.Enabled = !disableEdit;
				this.editorPassword.Text = String.Empty;
				this.editorNextId.Text = user.GetGraphElement((int)GraphKey.Users)?.NextId.ToString();
			}
		}

		private void GraphControllerAdministratorGroupMembership_BeforeCheckGraphElement(object sender, CheckGraphElementEventArgs e)
		{
			if (this.BindingObject is User user && user.Id == 1 && e.GraphElement?.SimpleObject is UserGroup userGroup && userGroup.Id == 1)
				e.CanCheck = false; // prevent adding/removing System Admin group membership for Administrators groups
		}

		private void editorPassword_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			if (this.BindingObject is User user && ((string)e.NewValue).Trim().Length > 0)
				user.PasswordHash = PasswordSecurity.HashPassword(((string)e.NewValue).Trim());
		}

		//private void editorPassword2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		//{
		//	if (this.BindingObject is User user && ((string)e.NewValue).Trim().Length > 0)
		//	{
		//		var passwordHash = PasswordSecurity.HashPassword(((string)e.NewValue).Trim());

		//		user.PasswordHash2 = PasswordSecurity.Encrypt(passwordHash, user.Manager.Encryptor);
		//	}
		//}
	}
}