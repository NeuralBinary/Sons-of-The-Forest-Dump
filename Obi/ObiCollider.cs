using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Obi
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	[RequireComponent(typeof(Collider))]
	[ExecuteInEditMode]
	public class ObiCollider : ObiColliderBase
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E3")]
		public Collider sourceCollider
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x27C8550", Offset = "0x27C6B50", VA = "0x1827C8550")]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E4")]
		public ObiDistanceField distanceField
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x27C8830", Offset = "0x27C6E30", VA = "0x1827C8830")]
			set
			{
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x27C89B0", Offset = "0x27C6FB0", VA = "0x1827C89B0", Slot = "4")]
		protected override void CreateTracker()
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x27C9500", Offset = "0x27C7B00", VA = "0x1827C9500", Slot = "5")]
		protected override Component GetUnityCollider(ref bool enabled)
		{
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x27C9620", Offset = "0x27C7C20", VA = "0x1827C9620", Slot = "6")]
		protected override void FindSourceCollider()
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x26C07A0", Offset = "0x26BEDA0", VA = "0x1826C07A0")]
		public ObiCollider()
		{
		}

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeProperty("sourceCollider")]
		[FormerlySerializedAs("SourceCollider")]
		[SerializeField]
		private Collider m_SourceCollider;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeProperty("distanceField")]
		[FormerlySerializedAs("distanceField")]
		[SerializeField]
		private ObiDistanceField m_DistanceField;
	}
}
