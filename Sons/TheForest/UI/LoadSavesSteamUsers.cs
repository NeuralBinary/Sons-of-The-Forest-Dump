using System;
using Il2CppDummyDll;
using NGUI.Tweening;
using NGUI.UI;
using Steamworks;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public class LoadSavesSteamUsers : MonoBehaviour
	{
		// Token: 0x06001B25 RID: 6949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x32B1710", Offset = "0x32AFD10", VA = "0x1832B1710")]
		private void Awake()
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x32B2700", Offset = "0x32B0D00", VA = "0x1832B2700")]
		private void Update()
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x32B2880", Offset = "0x32B0E80", VA = "0x1832B2880")]
		public void ToggleNextSteamUser()
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LoadSavesSteamUsers()
		{
		}

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha _slotRoot;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _label;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _nextUserButton;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x0")]
		private static int Current;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x8")]
		private static CSteamID[] SteamUserIDs;

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x10")]
		private static string[] SteamUserNames;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _refreshRoutine;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x40")]
		private int _routineStep;

		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x44")]
		private float _nextRoutineStep;
	}
}
