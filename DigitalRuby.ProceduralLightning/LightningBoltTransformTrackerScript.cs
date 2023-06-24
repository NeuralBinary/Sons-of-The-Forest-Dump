using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class LightningBoltTransformTrackerScript : MonoBehaviour
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA43980", Offset = "0xA41F80", VA = "0x180A43980")]
		private void Start()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA43AE0", Offset = "0xA420E0", VA = "0x180A43AE0")]
		private static float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
		{
			return 0f;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA43BB0", Offset = "0xA421B0", VA = "0x180A43BB0")]
		private static void UpdateTransform(LightningCustomTransformStateInfo state, LightningBoltPrefabScript script, RangeOfFloats scaleLimit)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA44930", Offset = "0xA42F30", VA = "0x180A44930")]
		public void CustomTransformHandler(LightningCustomTransformStateInfo state)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA44BA0", Offset = "0xA431A0", VA = "0x180A44BA0")]
		public LightningBoltTransformTrackerScript()
		{
		}

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The lightning script to track.")]
		public LightningBoltPrefabScript LightningScript;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The transform to track which will be where the bolts are emitted from.")]
		public Transform StartTarget;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) The transform to track which will be where the bolts are emitted to. If no end target is specified, lightning will simply move to stay on top of the start target.")]
		public Transform EndTarget;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x38")]
		[SingleLine("Scaling limits.")]
		public RangeOfFloats ScaleLimit;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<Transform, LightningCustomTransformStateInfo> transformStartPositions;
	}
}
