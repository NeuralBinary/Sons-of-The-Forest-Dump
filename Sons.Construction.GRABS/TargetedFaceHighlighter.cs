using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class TargetedFaceHighlighter : MonoBehaviour, IFaceTargetedReceiver
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2D978F0", Offset = "0x2D95EF0", VA = "0x182D978F0")]
		private void Start()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2D97940", Offset = "0x2D95F40", VA = "0x182D97940")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D97990", Offset = "0x2D95F90", VA = "0x182D97990")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2D98000", Offset = "0x2D96600", VA = "0x182D98000")]
		private VisualFader GetVisualInstance(BlueprintFace face)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2D98090", Offset = "0x2D96690", VA = "0x182D98090")]
		private void ReturnVisual(VisualFader visual)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2D981B0", Offset = "0x2D967B0", VA = "0x182D981B0", Slot = "4")]
		private void OnFaceTargeted(BlueprintFace face)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2D98630", Offset = "0x2D96C30", VA = "0x182D98630", Slot = "5")]
		private void OnFaceUntargeted(BlueprintFace face)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2D98790", Offset = "0x2D96D90", VA = "0x182D98790")]
		public TargetedFaceHighlighter()
		{
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<BlueprintFace, VisualFader> _activeVisuals;
	}
}
