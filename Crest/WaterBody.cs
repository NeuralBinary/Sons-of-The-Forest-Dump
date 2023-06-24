using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[ExecuteAlways]
	public class WaterBody : MonoBehaviour
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x170000B7")]
		public static List<WaterBody> WaterBodies
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xA25240", Offset = "0xA23840", VA = "0x180A25240")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public Bounds AABB
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xA25290", Offset = "0xA23890", VA = "0x180A25290")]
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xA252B0", Offset = "0xA238B0", VA = "0x180A252B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA252D0", Offset = "0xA238D0", VA = "0x180A252D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA25390", Offset = "0xA23990", VA = "0x180A25390")]
		private void OnDisable()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA25410", Offset = "0xA23A10", VA = "0x180A25410")]
		private void CalculateBounds()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public WaterBody()
		{
		}

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Editor only: run validation checks on Start() to check for issues.")]
		[SerializeField]
		private bool _runValidationOnStart;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		private static List<WaterBody> _waterBodies;
	}
}
