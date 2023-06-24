using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	public abstract class StructureStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x2BAA820", Offset = "0x2BA8E20", VA = "0x182BAA820", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x2BAA980", Offset = "0x2BA8F80", VA = "0x182BAA980")]
		protected bool IsOnRight(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x2BAAA10", Offset = "0x2BA9010", VA = "0x182BAAA10")]
		private void CheckCollision()
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "26")]
		protected virtual bool CheckTopFree()
		{
			return default(bool);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "27")]
		protected virtual bool CheckLeftFree()
		{
			return default(bool);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "28")]
		protected virtual bool CheckRightFree()
		{
			return default(bool);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x2BAAAE0", Offset = "0x2BA90E0", VA = "0x182BAAAE0")]
		public void Initialize(Vector3 rightDir, float width, float length, Vector3 worldCenter)
		{
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x2BAACC0", Offset = "0x2BA92C0", VA = "0x182BAACC0")]
		public Vector3 GetClosestPosition(Vector3 actorPos)
		{
			return default(Vector3);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x2BAAEE0", Offset = "0x2BA94E0", VA = "0x182BAAEE0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x2BAAF90", Offset = "0x2BA9590", VA = "0x182BAAF90", Slot = "24")]
		protected override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x2BAB000", Offset = "0x2BA9600", VA = "0x182BAB000")]
		private void DrawDebug()
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x2BAB510", Offset = "0x2BA9B10", VA = "0x182BAB510")]
		protected StructureStimuli()
		{
		}

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0xA8")]
		protected Vector2 _extent;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3 _rightDir;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0xBC")]
		protected Vector3 _forwardDir;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0xC8")]
		protected Vector3 _worldCenter;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0xD4")]
		private bool _canClimbLeft;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0xD5")]
		private bool _canClimbRight;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0xD6")]
		private bool _topFree;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0xD7")]
		private bool _initialized;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0xD8")]
		private float _lastCollisionRefreshTime;
	}
}
