using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public class FaceDebugVisualManager : MonoBehaviour, IFaceCreatedReceiver, IFaceChangedReceiver, IDestroyingFaceReceiver
	{
		// Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2DB06D0", Offset = "0x2DAECD0", VA = "0x182DB06D0")]
		private void Start()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2DB0780", Offset = "0x2DAED80", VA = "0x182DB0780")]
		private void Update()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2DB0970", Offset = "0x2DAEF70", VA = "0x182DB0970")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2DB09D0", Offset = "0x2DAEFD0", VA = "0x182DB09D0")]
		private void ToggleFaceDebugCommand(bool onOff)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2DB0E60", Offset = "0x2DAF460", VA = "0x182DB0E60")]
		private VisualFader GetVisualInstance(BlueprintFace face)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2DB0EF0", Offset = "0x2DAF4F0", VA = "0x182DB0EF0")]
		private void ReturnVisual(VisualFader visual)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2DB1010", Offset = "0x2DAF610", VA = "0x182DB1010")]
		private void InitAllBlueprints()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2DB12A0", Offset = "0x2DAF8A0", VA = "0x182DB12A0")]
		private void ClearAllVisuals()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2DB1530", Offset = "0x2DAFB30", VA = "0x182DB1530")]
		private Color GetRandomColor()
		{
			return default(Color);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2DB15B0", Offset = "0x2DAFBB0", VA = "0x182DB15B0")]
		private void CreateOrScaleVisual(BlueprintFace face)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2DB1B40", Offset = "0x2DB0140", VA = "0x182DB1B40")]
		private void InitVisualFader(VisualFader visualFader)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2DB1D30", Offset = "0x2DB0330", VA = "0x182DB1D30")]
		private void RemoveVisual(BlueprintFace face)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2DB1EE0", Offset = "0x2DB04E0", VA = "0x182DB1EE0", Slot = "4")]
		private void OnFaceCreated(BlueprintFace face)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2DB1EE0", Offset = "0x2DB04E0", VA = "0x182DB1EE0", Slot = "5")]
		private void OnFaceChanged(BlueprintFace face)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2DB1EF0", Offset = "0x2DB04F0", VA = "0x182DB1EF0", Slot = "6")]
		private void OnDestroyingFace(BlueprintFace face)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2DB1F00", Offset = "0x2DB0500", VA = "0x182DB1F00")]
		public FaceDebugVisualManager()
		{
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _opacity;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<BlueprintFace, VisualFader> _visuals;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<VisualFader> _pendingInitialization;
	}
}
