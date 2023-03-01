using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace TheForest.Save
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	public class PlayerSpawn : MonoBehaviour, IQuitHandler
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x2CE8510", Offset = "0x2CE7510", VA = "0x182CE8510")]
		private void Awake()
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x2CE8CA0", Offset = "0x2CE7CA0", VA = "0x182CE8CA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x2CE9050", Offset = "0x2CE8050", VA = "0x182CE9050")]
		private void SetupPlayer()
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x2CE94F0", Offset = "0x2CE84F0", VA = "0x182CE94F0")]
		private void SpawnAndSetupPlayerObject()
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x2CE8660", Offset = "0x2CE7660", VA = "0x182CE8660")]
		private void CheckActivatePlayer()
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x2CE8DD0", Offset = "0x2CE7DD0", VA = "0x182CE8DD0")]
		private void PlayerDelayedActivation()
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x2CE8790", Offset = "0x2CE7790", VA = "0x182CE8790")]
		public static string GetClientSaveFileName()
		{
			return null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x2CE88C0", Offset = "0x2CE78C0", VA = "0x182CE88C0")]
		public static bool HasMPCharacterSave()
		{
			return default(bool);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x2CE8A90", Offset = "0x2CE7A90", VA = "0x182CE8A90")]
		[Obsolete]
		private bool LoadMpCharacter()
		{
			return default(bool);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void InitPlayer()
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x2CE8A40", Offset = "0x2CE7A40", VA = "0x182CE8A40")]
		private IEnumerator LoadMpCharacterDelayed()
		{
			return null;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x2CE8600", Offset = "0x2CE7600", VA = "0x182CE8600")]
		public static void BlockPlayerActivation(bool value)
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x2CE8D30", Offset = "0x2CE7D30", VA = "0x182CE8D30", Slot = "4")]
		public void OnQuit()
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x2B37AA0", Offset = "0x2B36AA0", VA = "0x182B37AA0")]
		public PlayerSpawn()
		{
		}

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x0")]
		public static string MpCharacterSaveFileName;

		// Token: 0x04001ABC RID: 6844
		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x8")]
		[Obsolete]
		public static bool LoadSavedCharacter;

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x9")]
		[Obsolete]
		public static bool LoadingSavedCharacter;

		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _playerEditor;

		// Token: 0x04001ABF RID: 6847
		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _playerPrefab;

		// Token: 0x04001AC0 RID: 6848
		[Token(Token = "0x4001AC0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _playerUI;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x38")]
		public bool _planeCrash;

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _player;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0xA")]
		private static bool _blockPlayerActivation;
	}
}
