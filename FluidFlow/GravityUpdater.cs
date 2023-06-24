using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FluidSimulation
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[RequireComponent(typeof(FluidSimulator))]
	public class GravityUpdater : MonoBehaviour
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB07680", Offset = "0xB05C80", VA = "0x180B07680")]
		private void Start()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB079F0", Offset = "0xB05FF0", VA = "0x180B079F0")]
		private Vector3 calculateLocalGravity(Vector3 gravity)
		{
			return default(Vector3);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB07BF0", Offset = "0xB061F0", VA = "0x180B07BF0")]
		private void Update()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xB07D60", Offset = "0xB06360", VA = "0x180B07D60")]
		public GravityUpdater()
		{
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Update gravitymaps when local gravity direction changed by x degrees")]
		public float DeadzoneAngle;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastGrav;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		private FluidSimulator simulator;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		private Transform gravityRoot;
	}
}
