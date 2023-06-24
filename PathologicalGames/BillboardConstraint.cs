using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint - Billboard")]
	public class BillboardConstraint : LookAtBaseClass
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x28D36D0", Offset = "0x28D1CD0", VA = "0x1828D36D0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x28D3930", Offset = "0x28D1F30", VA = "0x1828D3930", Slot = "9")]
		protected override void OnConstraintUpdate()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x28D3DD0", Offset = "0x28D23D0", VA = "0x1828D3DD0")]
		public BillboardConstraint()
		{
		}

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x80")]
		public bool vertical;
	}
}
