using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x298ECF0", Offset = "0x298D2F0", VA = "0x18298ECF0")]
		public AimPoser.Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x298EDF0", Offset = "0x298D3F0", VA = "0x18298EDF0")]
		public void SetPoseActive(AimPoser.Pose pose)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x298EE70", Offset = "0x298D470", VA = "0x18298EE70")]
		public AimPoser()
		{
		}

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x20")]
		public float angleBuffer;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x28")]
		public AimPoser.Pose[] poses;

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		[Serializable]
		public class Pose
		{
			// Token: 0x060005C4 RID: 1476 RVA: 0x000043F4 File Offset: 0x000025F4
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x298EF30", Offset = "0x298D530", VA = "0x18298EF30")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			public void SetAngleBuffer(float value)
			{
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x298F290", Offset = "0x298D890", VA = "0x18298F290")]
			public Pose()
			{
			}

			// Token: 0x0400051E RID: 1310
			[Token(Token = "0x400051E")]
			[FieldOffset(Offset = "0x10")]
			public bool visualize;

			// Token: 0x0400051F RID: 1311
			[Token(Token = "0x400051F")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04000520 RID: 1312
			[Token(Token = "0x4000520")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			// Token: 0x04000521 RID: 1313
			[Token(Token = "0x4000521")]
			[FieldOffset(Offset = "0x2C")]
			public float yaw;

			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x4000522")]
			[FieldOffset(Offset = "0x30")]
			public float pitch;

			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x4000523")]
			[FieldOffset(Offset = "0x34")]
			private float angleBuffer;
		}
	}
}
