using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class TargetedFaceInteractionPointManager : MonoBehaviour, IFaceTargetedReceiver
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2D98870", Offset = "0x2D96E70", VA = "0x182D98870")]
		private void Start()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2D988C0", Offset = "0x2D96EC0", VA = "0x182D988C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2D98910", Offset = "0x2D96F10", VA = "0x182D98910")]
		private void Update()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2D98AB0", Offset = "0x2D970B0", VA = "0x182D98AB0")]
		private void CheckEnabledStatus()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2D98B40", Offset = "0x2D97140", VA = "0x182D98B40", Slot = "4")]
		private void OnFaceTargeted(BlueprintFace face)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2D98C10", Offset = "0x2D97210", VA = "0x182D98C10", Slot = "5")]
		private void OnFaceUntargeted(BlueprintFace face)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2D98CD0", Offset = "0x2D972D0", VA = "0x182D98CD0")]
		public TargetedFaceInteractionPointManager()
		{
		}

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BlueprintFace> _activeVisuals;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<BlueprintFace> _fadingAwayVisuals;
	}
}
