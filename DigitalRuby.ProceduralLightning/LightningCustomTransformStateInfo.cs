using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class LightningCustomTransformStateInfo
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public LightningCustomTransformState State
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return LightningCustomTransformState.Started;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public LightningBoltParameters Parameters
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA2EF00", Offset = "0xA2D500", VA = "0x180A2EF00")]
		public static LightningCustomTransformStateInfo GetOrCreateStateInfo()
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA2F000", Offset = "0xA2D600", VA = "0x180A2F000")]
		public static void ReturnStateInfoToCache(LightningCustomTransformStateInfo info)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LightningCustomTransformStateInfo()
		{
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 BoltStartPosition;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 BoltEndPosition;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x38")]
		public Transform Transform;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x40")]
		public Transform StartTransform;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x48")]
		public Transform EndTransform;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x50")]
		public object UserInfo;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<LightningCustomTransformStateInfo> cache;
	}
}
