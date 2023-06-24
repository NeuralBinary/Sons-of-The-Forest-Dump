using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public class LoadingProgress : MonoBehaviour
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000081F0 File Offset: 0x000063F0
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BF")]
		public static float Progress
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x32B0CA0", Offset = "0x32AF2A0", VA = "0x1832B0CA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x32B0CE0", Offset = "0x32AF2E0", VA = "0x1832B0CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x32B0D30", Offset = "0x32AF330", VA = "0x1832B0D30")]
		public static void ResetVisuals()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x32B0D70", Offset = "0x32AF370", VA = "0x1832B0D70")]
		private void Awake()
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x32B0DF0", Offset = "0x32AF3F0", VA = "0x1832B0DF0")]
		private void Update()
		{
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LoadingProgress()
		{
		}

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x20")]
		public Transform _progressBar;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 _from;

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 _to;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x40")]
		private float _lastProgressStep;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x44")]
		private float _lastTargetProgress;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x48")]
		private float _alpha;

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x4")]
		private static bool _forceReset;
	}
}
