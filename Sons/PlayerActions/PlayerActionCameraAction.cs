using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace Sons.PlayerActions
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	[AddComponentMenu("Sons/Actions/PlayerActionCameraAction")]
	public class PlayerActionCameraAction : MonoBehaviour
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048D")]
		private int CurrentVideoClipIndex
		{
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x3327890", Offset = "0x3325E90", VA = "0x183327890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			set
			{
			}
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x3327940", Offset = "0x3325F40", VA = "0x183327940")]
		public PlayerActionCameraAction.ClipData GetCurrentClip()
		{
			return null;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002159")]
		[Address(RVA = "0x33279F0", Offset = "0x3325FF0", VA = "0x1833279F0")]
		public PlayerActionCameraAction.ClipData GetNextClip()
		{
			return null;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215A")]
		[Address(RVA = "0x3327C50", Offset = "0x3326250", VA = "0x183327C50")]
		public PlayerActionCameraAction.ClipData GetPreviousClip()
		{
			return null;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x3327EB0", Offset = "0x33264B0", VA = "0x183327EB0")]
		private static bool HasAlreadyCollectedClip(string clipName)
		{
			return default(bool);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x600215C")]
		[Address(RVA = "0x3327F70", Offset = "0x3326570", VA = "0x183327F70")]
		public bool TryCollectVideoClip(string clipName)
		{
			return default(bool);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x3328190", Offset = "0x3326790", VA = "0x183328190")]
		public PlayerActionCameraAction()
		{
		}

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		private const string CurrentActionVideoIndex = "CurrentActionVideoIndex";

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		private const string ActionCameraVideoCollected = "ActionCameraVideoCollected";

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PlayerActionCameraAction.ClipData> _clips;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		[FieldOffset(Offset = "0x28")]
		private int _currentVideoClipIndex;

		// Token: 0x020004FE RID: 1278
		[Token(Token = "0x20004FE")]
		[Serializable]
		public class ClipData
		{
			// Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ClipData()
			{
			}

			// Token: 0x04001EFB RID: 7931
			[Token(Token = "0x4001EFB")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04001EFC RID: 7932
			[Token(Token = "0x4001EFC")]
			[FieldOffset(Offset = "0x18")]
			public VideoClip VideoClip;

			// Token: 0x04001EFD RID: 7933
			[Token(Token = "0x4001EFD")]
			[FieldOffset(Offset = "0x20")]
			[EventRef]
			public string AudioClip;
		}
	}
}
