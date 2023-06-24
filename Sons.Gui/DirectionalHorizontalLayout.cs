using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[AddComponentMenu("Sons/Gui/DirectionalHorizontalLayout")]
	public class DirectionalHorizontalLayout : MonoBehaviour, IDirectionalLayout
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3001470", Offset = "0x2FFFA70", VA = "0x183001470")]
		private void Awake()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x3001480", Offset = "0x2FFFA80", VA = "0x183001480")]
		private void Update()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3001470", Offset = "0x2FFFA70", VA = "0x183001470")]
		private void OnTransformChildrenChanged()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x3001540", Offset = "0x2FFFB40", VA = "0x183001540")]
		private void RefreshElementCache()
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "4")]
		public void RegisterOrderProvider(IOrderProvider orderProvider)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3001890", Offset = "0x2FFFE90", VA = "0x183001890")]
		private Order GetOrder()
		{
			return Order.Default;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x30018E0", Offset = "0x2FFFEE0", VA = "0x1830018E0")]
		private void CollectElementsToDisplay(Order order, out bool changed)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3001D90", Offset = "0x3000390", VA = "0x183001D90")]
		private void CalculateElementsPositions()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3002080", Offset = "0x3000680", VA = "0x183002080")]
		public DirectionalHorizontalLayout()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		private IOrderProvider _orderProvider;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<GameObject> _elementCache;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<RectTransform> _elementsToDisplay;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<RectTransform> _displayedElements;
	}
}
