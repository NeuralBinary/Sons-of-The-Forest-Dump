using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public struct Target : IComparable<Target>
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000060")]
		public static Target Null
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x28CE290", Offset = "0x28CC890", VA = "0x1828CE290")]
			get
			{
				return default(Target);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x28CE300", Offset = "0x28CC900", VA = "0x1828CE300")]
		public Target(Transform transform, TargetTracker targetTracker)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x28CE700", Offset = "0x28CCD00", VA = "0x1828CE700")]
		public Target(Target otherTarget)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x28CE920", Offset = "0x28CCF20", VA = "0x1828CE920")]
		public static bool operator ==(Target tA, Target tB)
		{
			return default(bool);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x28CEA80", Offset = "0x28CD080", VA = "0x1828CEA80")]
		public static bool operator !=(Target tA, Target tB)
		{
			return default(bool);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x28CEBE0", Offset = "0x28CD1E0", VA = "0x1828CEBE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x28CEC40", Offset = "0x28CD240", VA = "0x1828CEC40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000061")]
		public bool isSpawned
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x28CED50", Offset = "0x28CD350", VA = "0x1828CED50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x28CEE70", Offset = "0x28CD470", VA = "0x1828CEE70", Slot = "4")]
		public int CompareTo(Target obj)
		{
			return 0;
		}

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		public GameObject gameObject;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x8")]
		public Transform transform;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x10")]
		public Targetable targetable;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		public TargetTracker targetTracker;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		public FireController fireController;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		public Projectile projectile;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x0")]
		private static Target _Null;
	}
}
