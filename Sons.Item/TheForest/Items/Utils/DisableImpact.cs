using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Items.Utils
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class DisableImpact : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x30ADED0", Offset = "0x30AC4D0", VA = "0x1830ADED0")]
		private void Awake()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Start()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Update()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30AE0F0", Offset = "0x30AC6F0", VA = "0x1830AE0F0")]
		public void disableImpact(float interval, bool multiplayer = false)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30AE450", Offset = "0x30ACA50", VA = "0x1830AE450")]
		public void enableImpact()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DisableImpact()
		{
		}

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x20")]
		private Rigidbody body;
	}
}
