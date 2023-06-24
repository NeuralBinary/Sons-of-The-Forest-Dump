using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Serializable]
	public class Rudder
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002E1C File Offset: 0x0000101C
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000058")]
		public float Angle
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x17000059")]
		public float AnglePercent
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2716900", Offset = "0x2714F00", VA = "0x182716900")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void Initialize(AdvancedShipController sc)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2716910", Offset = "0x2714F10", VA = "0x182716910", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2716B80", Offset = "0x2715180", VA = "0x182716B80")]
		public Rudder()
		{
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x18")]
		public Transform rudderTransform;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x20")]
		public float maxAngle;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 localRotationAxis;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x38")]
		private AdvancedShipController _sc;
	}
}
