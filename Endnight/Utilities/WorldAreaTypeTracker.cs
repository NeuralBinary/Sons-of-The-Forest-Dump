using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Utilities
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public class WorldAreaTypeTracker : MonoBehaviour
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public WorldAreaTypes ActiveArea
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return WorldAreaTypes.Outside;
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA8E460", Offset = "0xA8CA60", VA = "0x180A8E460")]
		private void Start()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA8E900", Offset = "0xA8CF00", VA = "0x180A8E900")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA8EA00", Offset = "0xA8D000", VA = "0x180A8EA00")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA8EB00", Offset = "0xA8D100", VA = "0x180A8EB00")]
		private void UpdateCurrentAreaType()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA8EBB0", Offset = "0xA8D1B0", VA = "0x180A8EBB0")]
		private WorldAreaTypes CalculateDominantAreaType()
		{
			return WorldAreaTypes.Outside;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA8EC20", Offset = "0xA8D220", VA = "0x180A8EC20")]
		public WorldAreaTypeTracker()
		{
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<WorldAreaTypes> WorldAreaTypeChangedEvent;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x30")]
		private int[] _areaTypeCount;
	}
}
