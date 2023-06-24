using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Input
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class InputIconProgress : MonoBehaviour, IHeldInputProgressReceiver
	{
		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x305AAD0", Offset = "0x30590D0", VA = "0x18305AAD0")]
		private void OnValidate()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x305ADE0", Offset = "0x30593E0", VA = "0x18305ADE0")]
		public void SetShowWhenIdle(bool value)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x305AE50", Offset = "0x3059450", VA = "0x18305AE50")]
		private void OnEnable()
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x305AE60", Offset = "0x3059460", VA = "0x18305AE60")]
		private void OnDisable()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x305AE70", Offset = "0x3059470", VA = "0x18305AE70", Slot = "4")]
		public void Started()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x305AEA0", Offset = "0x30594A0", VA = "0x18305AEA0", Slot = "5")]
		public void Stopped()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x305AED0", Offset = "0x30594D0", VA = "0x18305AED0")]
		private void SetEnabled(bool value)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x305B2F0", Offset = "0x30598F0", VA = "0x18305B2F0", Slot = "6")]
		public void UpdateProgress(float progress)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x305B590", Offset = "0x3059B90", VA = "0x18305B590")]
		public InputIconProgress()
		{
		}

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private Image _image;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ProgressImageDef> _imageDefs;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _linkEnabled;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _linkDisabled;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private float _idleProgressAmount;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _showWhenIdle;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x4D")]
		private bool _isEnabled;
	}
}
