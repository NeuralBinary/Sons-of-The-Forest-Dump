using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200096A RID: 2410
	[Token(Token = "0x200096A")]
	[Serializable]
	public class ButterflyLandLocation : MonoBehaviour
	{
		// Token: 0x060045D1 RID: 17873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x366B9F0", Offset = "0x3669FF0", VA = "0x18366B9F0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D2")]
		[Address(RVA = "0x366B9F0", Offset = "0x3669FF0", VA = "0x18366B9F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D3")]
		[Address(RVA = "0x366BA00", Offset = "0x366A000", VA = "0x18366BA00")]
		private void CheckRegister()
		{
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x366BC50", Offset = "0x366A250", VA = "0x18366BC50")]
		private void OnDisable()
		{
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x366BE70", Offset = "0x366A470", VA = "0x18366BE70")]
		private bool VerifySpawner()
		{
			return default(bool);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ButterflyLandLocation()
		{
		}

		// Token: 0x0400486A RID: 18538
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x20")]
		private List<PlayerButterflySpawner> _spawners;
	}
}
