using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	public class TransformSequence
	{
		// Token: 0x060010DA RID: 4314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x1E49850", Offset = "0x1E47E50", VA = "0x181E49850")]
		public TransformSequence()
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x1E49900", Offset = "0x1E47F00", VA = "0x181E49900")]
		public TransformSequence(TransformSequence copy)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x1E499D0", Offset = "0x1E47FD0", VA = "0x181E499D0")]
		public void Append(TransformSequence sequence)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x1E49A40", Offset = "0x1E48040", VA = "0x181E49A40")]
		public void AppendTranslation(Vector3d dv)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x1E49B80", Offset = "0x1E48180", VA = "0x181E49B80")]
		public void AppendTranslation(double dx, double dy, double dz)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x1E49CE0", Offset = "0x1E482E0", VA = "0x181E49CE0")]
		public void AppendRotation(Quaternionf q)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x1E49E60", Offset = "0x1E48460", VA = "0x181E49E60")]
		public void AppendRotation(Quaternionf q, Vector3d aroundPt)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x1E49FA0", Offset = "0x1E485A0", VA = "0x181E49FA0")]
		public void AppendScale(Vector3d s)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x1E4A0E0", Offset = "0x1E486E0", VA = "0x181E4A0E0")]
		public void AppendScale(Vector3d s, Vector3d aroundPt)
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x1E4A230", Offset = "0x1E48830", VA = "0x181E4A230")]
		public void AppendToFrame(Frame3f frame)
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x1E4A3D0", Offset = "0x1E489D0", VA = "0x181E4A3D0")]
		public void AppendFromFrame(Frame3f frame)
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x1E4A570", Offset = "0x1E48B70", VA = "0x181E4A570")]
		public Vector3d TransformP(Vector3d p)
		{
			return default(Vector3d);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0000CD34 File Offset: 0x0000AF34
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x1E4AE70", Offset = "0x1E49470", VA = "0x181E4AE70")]
		public Vector3d TransformV(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x1E4B2D0", Offset = "0x1E498D0", VA = "0x181E4B2D0")]
		public Vector3f TransformP(Vector3f p)
		{
			return default(Vector3f);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x1E4B3C0", Offset = "0x1E499C0", VA = "0x181E4B3C0")]
		public TransformSequence MakeInverse()
		{
			return null;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x1E4BB70", Offset = "0x1E4A170", VA = "0x181E4BB70")]
		public void Store(BinaryWriter writer)
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x1E4BE80", Offset = "0x1E4A480", VA = "0x181E4BE80")]
		public void Restore(BinaryReader reader)
		{
		}

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x10")]
		private List<TransformSequence.XForm> Operations;

		// Token: 0x02000200 RID: 512
		[Token(Token = "0x2000200")]
		private enum XFormType
		{
			// Token: 0x0400082F RID: 2095
			[Token(Token = "0x400082F")]
			Translation,
			// Token: 0x04000830 RID: 2096
			[Token(Token = "0x4000830")]
			QuaterionRotation,
			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			QuaternionRotateAroundPoint,
			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			Scale,
			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			ScaleAroundPoint,
			// Token: 0x04000834 RID: 2100
			[Token(Token = "0x4000834")]
			ToFrame,
			// Token: 0x04000835 RID: 2101
			[Token(Token = "0x4000835")]
			FromFrame
		}

		// Token: 0x02000201 RID: 513
		[Token(Token = "0x2000201")]
		private struct XForm
		{
			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x060010EB RID: 4331 RVA: 0x0000CD64 File Offset: 0x0000AF64
			[Token(Token = "0x170002B2")]
			public Vector3d Translation
			{
				[Token(Token = "0x60010EB")]
				[Address(RVA = "0xF9B970", Offset = "0xF99F70", VA = "0x180F9B970")]
				get
				{
					return default(Vector3d);
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x060010EC RID: 4332 RVA: 0x0000CD7C File Offset: 0x0000AF7C
			[Token(Token = "0x170002B3")]
			public Vector3d Scale
			{
				[Token(Token = "0x60010EC")]
				[Address(RVA = "0xF9B970", Offset = "0xF99F70", VA = "0x180F9B970")]
				get
				{
					return default(Vector3d);
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x060010ED RID: 4333 RVA: 0x0000CD94 File Offset: 0x0000AF94
			[Token(Token = "0x170002B4")]
			public Quaternionf Quaternion
			{
				[Token(Token = "0x60010ED")]
				[Address(RVA = "0x1E4C250", Offset = "0x1E4A850", VA = "0x181E4C250")]
				get
				{
					return default(Quaternionf);
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x060010EE RID: 4334 RVA: 0x0000CDAC File Offset: 0x0000AFAC
			[Token(Token = "0x170002B5")]
			public Vector3d RotateOrigin
			{
				[Token(Token = "0x60010EE")]
				[Address(RVA = "0x1E4C290", Offset = "0x1E4A890", VA = "0x181E4C290")]
				get
				{
					return default(Vector3d);
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x060010EF RID: 4335 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
			[Token(Token = "0x170002B6")]
			public Frame3f Frame
			{
				[Token(Token = "0x60010EF")]
				[Address(RVA = "0x1E4C2B0", Offset = "0x1E4A8B0", VA = "0x181E4C2B0")]
				get
				{
					return default(Frame3f);
				}
			}

			// Token: 0x04000836 RID: 2102
			[Token(Token = "0x4000836")]
			[FieldOffset(Offset = "0x0")]
			public TransformSequence.XFormType type;

			// Token: 0x04000837 RID: 2103
			[Token(Token = "0x4000837")]
			[FieldOffset(Offset = "0x8")]
			public Vector3dTuple3 data;
		}
	}
}
