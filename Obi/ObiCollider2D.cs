using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Collider2D))]
	public class ObiCollider2D : ObiColliderBase
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E5")]
		public Collider2D SourceCollider
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x27C9720", Offset = "0x27C7D20", VA = "0x1827C9720")]
			set
			{
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x27C9980", Offset = "0x27C7F80", VA = "0x1827C9980", Slot = "4")]
		protected override void CreateTracker()
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x27C9F50", Offset = "0x27C8550", VA = "0x1827C9F50", Slot = "5")]
		protected override Component GetUnityCollider(ref bool enabled)
		{
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x27CA070", Offset = "0x27C8670", VA = "0x1827CA070", Slot = "6")]
		protected override void FindSourceCollider()
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x26C07A0", Offset = "0x26BEDA0", VA = "0x1826C07A0")]
		public ObiCollider2D()
		{
		}

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeProperty("SourceCollider")]
		[SerializeField]
		private Collider2D sourceCollider;
	}
}
