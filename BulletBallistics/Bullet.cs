using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class Bullet : PoolingObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public int Id
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x9048C0", Offset = "0x902EC0", VA = "0x1809048C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x9048D0", Offset = "0x902ED0", VA = "0x1809048D0")]
		private void Awake()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x904A30", Offset = "0x903030", VA = "0x180904A30", Slot = "5")]
		public virtual void SetPosition(Vector3 position, Vector3 offset)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x904FD0", Offset = "0x9035D0", VA = "0x180904FD0", Slot = "4")]
		public override void ReAwake()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9050E0", Offset = "0x9036E0", VA = "0x1809050E0", Slot = "6")]
		public virtual void SurfaceImpact(SurfaceImpactInfo surfaceImpactInfo)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x905170", Offset = "0x903770", VA = "0x180905170", Slot = "7")]
		public virtual void Impact(ImpactInfo impactInfo)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x9051F0", Offset = "0x9037F0", VA = "0x1809051F0")]
		public Bullet()
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		private static int _bulletIdCount;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		private TrailRenderer trail;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		public OnSurfaceImpactEvent OnSurfaceImpact;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		public OnImpactEvent OnImpact;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x44")]
		private bool _shouldCacheRotation;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion _startingRotationOffset;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion _startingRotation;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x68")]
		private bool _firstUpdateDone;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _cachedPosition;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x78")]
		private bool _positionIsCached;
	}
}
