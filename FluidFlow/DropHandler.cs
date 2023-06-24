using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FluidSimulation
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[RequireComponent(typeof(FluidSimulator))]
	public class DropHandler : MonoBehaviour
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xAFCB50", Offset = "0xAFB150", VA = "0x180AFCB50")]
		private void Awake()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xAFCE30", Offset = "0xAFB430", VA = "0x180AFCE30")]
		public void OnDrip(Vector3 position, float amount)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public DropHandler()
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject dropPrefab;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		public float dropLifeTime;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		private FluidSimulator simulator;
	}
}
