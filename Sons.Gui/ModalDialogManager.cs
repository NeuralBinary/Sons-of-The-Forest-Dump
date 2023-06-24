using System;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class ModalDialogManager : SingletonBehaviour<ModalDialogManager>
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3009050", Offset = "0x3007650", VA = "0x183009050")]
		public static DynamicModalDialogController Show(ModalDialogManager.Dialog type, [Optional] object[] objects)
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x30090C0", Offset = "0x30076C0", VA = "0x1830090C0")]
		public static DynamicModalDialogController Show(ModalDialogManager.Dialog type, string defaultInputText, [Optional] object[] objects)
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3009140", Offset = "0x3007740", VA = "0x183009140")]
		public static DynamicModalDialogController Show(ModalDialogManager.Dialog type, string defaultInputText, bool isPasswordInput, [Optional] object[] objects)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30091C0", Offset = "0x30077C0", VA = "0x1830091C0")]
		public static void ForceClose()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x3009200", Offset = "0x3007800", VA = "0x183009200")]
		private DynamicModalDialogController Show_Internal(ModalDialogManager.Dialog type, object[] objects, string defaultInputText, bool isPasswordInput)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3009370", Offset = "0x3007970", VA = "0x183009370")]
		private DynamicModalDialogController Show_Internal(DynamicModalDialogController controller, object[] objects, string defaultInputText, bool isPasswordInput)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3009840", Offset = "0x3007E40", VA = "0x183009840")]
		private void ForceClose_Internal()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30099F0", Offset = "0x3007FF0", VA = "0x1830099F0")]
		public ModalDialogManager()
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Dialogs")]
		[SerializeField]
		private DynamicModalDialogController LobbyInviteDialog;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DynamicModalDialogController LobbyInviteAcceptDialog;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DynamicModalDialogController NewSaveConfirmDialog;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DynamicModalDialogController VersionMismatchDialog;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DynamicModalDialogController HostLeftLobbyDialog;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DynamicModalDialogController CreateSaveConfirmDialog;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DynamicModalDialogController OverwriteSaveConfirmDialog;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DynamicModalDialogController LobbyFullDialog;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DynamicModalDialogController KickedFromGameDialog;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DynamicModalDialogController BannedFromGameDialog;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DynamicModalDialogController BanConfirmDialog;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DynamicModalDialogController ResetSettingsConfirmDialog;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private DynamicModalDialogController ResetKeyboardBindingsConfirmDialog;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DynamicModalDialogController ResetGamepadBindingsConfirmDialog;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DynamicModalDialogController QuitGameConfirmDialog;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DynamicModalDialogController DeleteSaveConfirmDialog;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DynamicModalDialogController DedicatedGameInviteDialog;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private DynamicModalDialogController DedicatedGameFullDialog;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private DynamicModalDialogController LanDedicatedGameDialog;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private DynamicModalDialogController ConnectPasswordInputDialog;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private DynamicModalDialogController WrongPasswordDialog;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private DynamicModalDialogController GameStartingDialog;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Debug")]
		public DynamicModalDialogController Current;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public enum Dialog
		{
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			LobbyInvite,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			LobbyInviteAccept,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			NewSaveConfirm,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			VersionMismatch,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			HostLeftLobby,
			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			OverwriteSaveConfirm,
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			LobbyFull,
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			KickedFromGame,
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			BannedFromGame,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			BanConfirm,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			ResetSettingsConfirm,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			ResetKeyboardBindingsConfirm,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			ResetGamepadBindingsConfirm,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			QuitGameConfirm,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			DeleteSaveConfirm,
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			CreateSaveConfirm,
			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			DedicatedGameInvite,
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			DedicatedGameFull,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			LanDedicatedGame,
			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			ConnectPasswordInput,
			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			WrongPassword,
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			GameStarting
		}
	}
}
