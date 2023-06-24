using System;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

namespace TheForest.Utils.VR
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class InputHint : MonoBehaviour
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetLabelTextValue(string value)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void SetDelayedAction(DelayedAction delayedAction)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x30AAB80", Offset = "0x30A9180", VA = "0x1830AAB80")]
		private void Update()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x30AABA0", Offset = "0x30A91A0", VA = "0x1830AABA0")]
		private void RefreshProgress()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x30AADC0", Offset = "0x30A93C0", VA = "0x1830AADC0")]
		private void RefreshPositions()
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x30ABB50", Offset = "0x30AA150", VA = "0x1830ABB50")]
		private void UpdateText()
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x30ABC70", Offset = "0x30AA270", VA = "0x1830ABC70")]
		private void ShowText(bool showValue)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x30ABCE0", Offset = "0x30AA2E0", VA = "0x1830ABCE0")]
		private Vector3 GetOffsetDirection(Player player)
		{
			return default(Vector3);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x30ABF00", Offset = "0x30AA500", VA = "0x1830ABF00")]
		public void Dispose()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x30ABF50", Offset = "0x30AA550", VA = "0x1830ABF50")]
		public InputHint()
		{
		}

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BaseGameObject;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x28")]
		public Transform StartTransform;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x30")]
		public Transform EndTransform;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x38")]
		public Transform InputTransformTarget;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x40")]
		public LineRenderer LineRenderer;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x48")]
		public InputHintProgress Progress;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ProgressRoot;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x58")]
		public float OffsetFactor;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x60")]
		public Transform OffsetSourceTransform;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x68")]
		public float LeftRightOffset;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x70")]
		private string _labelTextValue;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x78")]
		public Text Text;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x80")]
		public GameObject TextBaseObject;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x88")]
		private DelayedAction _delayedAction;
	}
}
