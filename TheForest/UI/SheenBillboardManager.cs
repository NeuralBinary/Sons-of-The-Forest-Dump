using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	[Obsolete]
	public class SheenBillboardManager : MonoBehaviour
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x2CEC6F0", Offset = "0x2CEB6F0", VA = "0x182CEC6F0")]
		private void Awake()
		{
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x2CECAF0", Offset = "0x2CEBAF0", VA = "0x182CECAF0")]
		private void Update()
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x2CEC750", Offset = "0x2CEB750", VA = "0x182CEC750")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x2CEC870", Offset = "0x2CEB870", VA = "0x182CEC870")]
		public static void Register(SheenBillboard sb)
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x2CEC990", Offset = "0x2CEB990", VA = "0x182CEC990")]
		public static void Unregister(SheenBillboard sb)
		{
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		private static SheenBillboardManager Instance
		{
			[Token(Token = "0x6001B1B")]
			[Address(RVA = "0x2CECF10", Offset = "0x2CEBF10", VA = "0x182CECF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x2CECE50", Offset = "0x2CEBE50", VA = "0x182CECE50")]
		public SheenBillboardManager()
		{
		}

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x20")]
		public float _offshootRatio;

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x24")]
		public float _hFovRatio;

		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x28")]
		public float _groupingRange;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x2C")]
		public float _dotUpdateThreshold;

		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x30")]
		public bool _legacy;

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x34")]
		private int _lastInactiveIconsIndex;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x38")]
		private int _lastActiveIconsIndex;

		// Token: 0x04001A6C RID: 6764
		[Token(Token = "0x4001A6C")]
		[FieldOffset(Offset = "0x40")]
		private List<SheenBillboard> _inactiveIcons;

		// Token: 0x04001A6D RID: 6765
		[Token(Token = "0x4001A6D")]
		[FieldOffset(Offset = "0x48")]
		private List<SheenBillboard> _activeIcons;

		// Token: 0x04001A6E RID: 6766
		[Token(Token = "0x4001A6E")]
		[FieldOffset(Offset = "0x0")]
		private static SheenBillboardManager _instance;
	}
}
