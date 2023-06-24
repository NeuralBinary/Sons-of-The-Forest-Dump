using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
	public class UICenterOnChild : MonoBehaviour
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000149")]
		public GameObject centeredObject
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x26AFF70", Offset = "0x26AE570", VA = "0x1826AFF70")]
		private void Start()
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x26AFF80", Offset = "0x26AE580", VA = "0x1826AFF80")]
		private void OnEnable()
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x26B00A0", Offset = "0x26AE6A0", VA = "0x1826B00A0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x26B01D0", Offset = "0x26AE7D0", VA = "0x1826B01D0")]
		private void OnDragFinished()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x26B0240", Offset = "0x26AE840", VA = "0x1826B0240")]
		private void OnValidate()
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x26B0260", Offset = "0x26AE860", VA = "0x1826B0260")]
		[ContextMenu("Execute")]
		public void Recenter()
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x26B1760", Offset = "0x26AFD60", VA = "0x1826B1760")]
		private void CenterOn(Transform target, Vector3 panelCenter)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x26B1CC0", Offset = "0x26B02C0", VA = "0x1826B1CC0")]
		public void CenterOn(Transform target)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x26B1F10", Offset = "0x26B0510", VA = "0x1826B1F10")]
		public UICenterOnChild()
		{
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x20")]
		public float springStrength;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x24")]
		public float nextPageThreshold;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x28")]
		public SpringPanel.OnFinished onFinished;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x30")]
		public UICenterOnChild.OnCenterCallback onCenter;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x38")]
		private UIScrollView mScrollView;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x40")]
		private GameObject mCenteredObject;

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000634 RID: 1588
		[Token(Token = "0x20000A7")]
		public delegate void OnCenterCallback(GameObject centeredObject);
	}
}
