using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class SnapScrollToSelected : MonoBehaviour
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3018A80", Offset = "0x3017080", VA = "0x183018A80")]
		private void OnValidate()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3018CD0", Offset = "0x30172D0", VA = "0x183018CD0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3018CD0", Offset = "0x30172D0", VA = "0x183018CD0")]
		private void ResetScroll()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3018E60", Offset = "0x3017460", VA = "0x183018E60")]
		private void Update()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x3019550", Offset = "0x3017B50", VA = "0x183019550")]
		private GameObject GetActiveSelection()
		{
			return null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3019660", Offset = "0x3017C60", VA = "0x183019660")]
		private bool IsChild(GameObject foundSelectedObject)
		{
			return default(bool);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x3019940", Offset = "0x3017F40", VA = "0x183019940")]
		private void SmoothTransition()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x3019A80", Offset = "0x3018080", VA = "0x183019A80")]
		private void FinalizeSnap()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3019B10", Offset = "0x3018110", VA = "0x183019B10")]
		private void Apply(GameObject target)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x3019C90", Offset = "0x3018290", VA = "0x183019C90")]
		public void SnapTo(RectTransform target)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x301A060", Offset = "0x3018660", VA = "0x18301A060")]
		public SnapScrollToSelected()
		{
		}

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _topAndBotPadding;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _smooth;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _smoothTime;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _smoothGoalSnap;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _contentPanel;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _lastTrackedChild;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 _goalOffset;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x50")]
		private bool _atGoal;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 _smoothVelocity;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _lastSelectedObject;
	}
}
