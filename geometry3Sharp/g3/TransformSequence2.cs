using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public class TransformSequence2 : ITransform2
	{
		// Token: 0x060010F3 RID: 4339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x1E4C390", Offset = "0x1E4A990", VA = "0x181E4C390")]
		public TransformSequence2()
		{
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x1E4C440", Offset = "0x1E4AA40", VA = "0x181E4C440")]
		public TransformSequence2 Translation(Vector2d dv)
		{
			return null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x1E4C530", Offset = "0x1E4AB30", VA = "0x181E4C530")]
		public TransformSequence2 Translation(double dx, double dy)
		{
			return null;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F6")]
		[Address(RVA = "0x1E4C620", Offset = "0x1E4AC20", VA = "0x181E4C620")]
		public TransformSequence2 RotationRad(double angle)
		{
			return null;
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x1E4C710", Offset = "0x1E4AD10", VA = "0x181E4C710")]
		public TransformSequence2 RotationDeg(double angle)
		{
			return null;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x1E4C810", Offset = "0x1E4AE10", VA = "0x181E4C810")]
		public TransformSequence2 RotationRad(double angle, Vector2d aroundPt)
		{
			return null;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x1E4C8E0", Offset = "0x1E4AEE0", VA = "0x181E4C8E0")]
		public TransformSequence2 RotationDeg(double angle, Vector2d aroundPt)
		{
			return null;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x1E4C9C0", Offset = "0x1E4AFC0", VA = "0x181E4C9C0")]
		public TransformSequence2 Scale(Vector2d s)
		{
			return null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x1E4CAB0", Offset = "0x1E4B0B0", VA = "0x181E4CAB0")]
		public TransformSequence2 Scale(Vector2d s, Vector2d aroundPt)
		{
			return null;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x1E4CB70", Offset = "0x1E4B170", VA = "0x181E4CB70")]
		public TransformSequence2 Append(ITransform2 t2)
		{
			return null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0000CDDC File Offset: 0x0000AFDC
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x1E4CC70", Offset = "0x1E4B270", VA = "0x181E4CC70", Slot = "4")]
		public Vector2d TransformP(Vector2d p)
		{
			return default(Vector2d);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x1E4D3D0", Offset = "0x1E4B9D0", VA = "0x181E4D3D0", Slot = "5")]
		public Vector2d TransformN(Vector2d n)
		{
			return default(Vector2d);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0000CE0C File Offset: 0x0000B00C
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x1E4D7F0", Offset = "0x1E4BDF0", VA = "0x181E4D7F0", Slot = "6")]
		public double TransformScalar(double s)
		{
			return 0.0;
		}

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x10")]
		private List<TransformSequence2.XForm> Operations;

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		private enum XFormType
		{
			// Token: 0x0400083A RID: 2106
			[Token(Token = "0x400083A")]
			Translation,
			// Token: 0x0400083B RID: 2107
			[Token(Token = "0x400083B")]
			Rotation,
			// Token: 0x0400083C RID: 2108
			[Token(Token = "0x400083C")]
			RotateAroundPoint,
			// Token: 0x0400083D RID: 2109
			[Token(Token = "0x400083D")]
			Scale,
			// Token: 0x0400083E RID: 2110
			[Token(Token = "0x400083E")]
			ScaleAroundPoint,
			// Token: 0x0400083F RID: 2111
			[Token(Token = "0x400083F")]
			NestedITransform2 = 10
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		private struct XForm
		{
			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06001100 RID: 4352 RVA: 0x0000CE24 File Offset: 0x0000B024
			[Token(Token = "0x170002B7")]
			public Vector2d Translation
			{
				[Token(Token = "0x6001100")]
				[Address(RVA = "0xF9BB80", Offset = "0xF9A180", VA = "0x180F9BB80")]
				get
				{
					return default(Vector2d);
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06001101 RID: 4353 RVA: 0x0000CE3C File Offset: 0x0000B03C
			[Token(Token = "0x170002B8")]
			public Vector2d Scale
			{
				[Token(Token = "0x6001101")]
				[Address(RVA = "0xF9BB80", Offset = "0xF9A180", VA = "0x180F9BB80")]
				get
				{
					return default(Vector2d);
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06001102 RID: 4354 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x170002B9")]
			public Matrix2d Rotation
			{
				[Token(Token = "0x6001102")]
				[Address(RVA = "0x1E4DA40", Offset = "0x1E4C040", VA = "0x181E4DA40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06001103 RID: 4355 RVA: 0x0000CE54 File Offset: 0x0000B054
			[Token(Token = "0x170002BA")]
			public Vector2d RotateOrigin
			{
				[Token(Token = "0x6001103")]
				[Address(RVA = "0x61A590", Offset = "0x618B90", VA = "0x18061A590")]
				get
				{
					return default(Vector2d);
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06001104 RID: 4356 RVA: 0x0000CE6C File Offset: 0x0000B06C
			[Token(Token = "0x170002BB")]
			public bool ScaleIsUniform
			{
				[Token(Token = "0x6001104")]
				[Address(RVA = "0x1E4DAA0", Offset = "0x1E4C0A0", VA = "0x181E4DAA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06001105 RID: 4357 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x170002BC")]
			public ITransform2 NestedITransform2
			{
				[Token(Token = "0x6001105")]
				[Address(RVA = "0x1E4DB70", Offset = "0x1E4C170", VA = "0x181E4DB70")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000840 RID: 2112
			[Token(Token = "0x4000840")]
			[FieldOffset(Offset = "0x0")]
			public TransformSequence2.XFormType type;

			// Token: 0x04000841 RID: 2113
			[Token(Token = "0x4000841")]
			[FieldOffset(Offset = "0x8")]
			public Vector2dTuple2 data;

			// Token: 0x04000842 RID: 2114
			[Token(Token = "0x4000842")]
			[FieldOffset(Offset = "0x28")]
			public object xform;
		}
	}
}
