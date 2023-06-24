using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace TheForest.Save
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public class PlayerSpawn : MonoBehaviour, IQuitHandler
	{
		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x32BD190", Offset = "0x32BB790", VA = "0x1832BD190")]
		private void Awake()
		{
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x32BD2E0", Offset = "0x32BB8E0", VA = "0x1832BD2E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x32BD370", Offset = "0x32BB970", VA = "0x1832BD370")]
		private void SetupPlayer()
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x32BD660", Offset = "0x32BBC60", VA = "0x1832BD660")]
		private void SpawnAndSetupPlayerObject()
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x32BD990", Offset = "0x32BBF90", VA = "0x1832BD990")]
		private void CheckActivatePlayer()
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x32BDAD0", Offset = "0x32BC0D0", VA = "0x1832BDAD0")]
		private void PlayerDelayedActivation()
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x32BDDD0", Offset = "0x32BC3D0", VA = "0x1832BDDD0")]
		public static string GetClientSaveFileName()
		{
			return null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x32BDE90", Offset = "0x32BC490", VA = "0x1832BDE90")]
		public static bool HasMPCharacterSave()
		{
			return default(bool);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x32BDFA0", Offset = "0x32BC5A0", VA = "0x1832BDFA0")]
		[Obsolete]
		private bool LoadMpCharacter()
		{
			return default(bool);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void InitPlayer()
		{
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x32BE080", Offset = "0x32BC680", VA = "0x1832BE080")]
		private IEnumerator LoadMpCharacterDelayed()
		{
			return null;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x32BE0C0", Offset = "0x32BC6C0", VA = "0x1832BE0C0")]
		public static void BlockPlayerActivation(bool value)
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x32BE120", Offset = "0x32BC720", VA = "0x1832BE120", Slot = "4")]
		public void OnQuit()
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x317DC50", Offset = "0x317C250", VA = "0x18317DC50")]
		public PlayerSpawn()
		{
		}

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x0")]
		public static string MpCharacterSaveFileName;

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x8")]
		[Obsolete]
		public static bool LoadSavedCharacter;

		// Token: 0x04001AE1 RID: 6881
		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0x9")]
		[Obsolete]
		public static bool LoadingSavedCharacter;

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _playerEditor;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _playerPrefab;

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _playerUI;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x38")]
		public bool _planeCrash;

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _player;

		// Token: 0x04001AE7 RID: 6887
		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0xA")]
		private static bool _blockPlayerActivation;
	}
}
