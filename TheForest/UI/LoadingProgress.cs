using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public class LoadingProgress : MonoBehaviour
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00007F68 File Offset: 0x00006168
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B5")]
		public static float Progress
		{
			[Token(Token = "0x6001AD8")]
			[Address(RVA = "0x2CE6710", Offset = "0x2CE5710", VA = "0x182CE6710")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001AD9")]
			[Address(RVA = "0x2CE6750", Offset = "0x2CE5750", VA = "0x182CE6750")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x2CE6290", Offset = "0x2CE5290", VA = "0x182CE6290")]
		public static void ResetVisuals()
		{
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x2CE6210", Offset = "0x2CE5210", VA = "0x182CE6210")]
		private void Awake()
		{
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x2CE62D0", Offset = "0x2CE52D0", VA = "0x182CE62D0")]
		private void Update()
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LoadingProgress()
		{
		}

		// Token: 0x04001A28 RID: 6696
		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x20")]
		public Transform _progressBar;

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 _from;

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 _to;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x40")]
		private float _lastProgressStep;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x44")]
		private float _lastTargetProgress;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x48")]
		private float _alpha;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x4")]
		private static bool _forceReset;
	}
}
