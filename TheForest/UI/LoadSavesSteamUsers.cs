using System;
using Il2CppDummyDll;
using NGUI.Tweening;
using NGUI.UI;
using Steamworks;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class LoadSavesSteamUsers : MonoBehaviour
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x2CE5520", Offset = "0x2CE4520", VA = "0x182CE5520")]
		private void Awake()
		{
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x2CE6080", Offset = "0x2CE5080", VA = "0x182CE6080")]
		private void Update()
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x2CE5EA0", Offset = "0x2CE4EA0", VA = "0x182CE5EA0")]
		public void ToggleNextSteamUser()
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LoadSavesSteamUsers()
		{
		}

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha _slotRoot;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _label;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _nextUserButton;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x0")]
		private static int Current;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x8")]
		private static CSteamID[] SteamUserIDs;

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x10")]
		private static string[] SteamUserNames;

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _refreshRoutine;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x40")]
		private int _routineStep;

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x44")]
		private float _nextRoutineStep;
	}
}
