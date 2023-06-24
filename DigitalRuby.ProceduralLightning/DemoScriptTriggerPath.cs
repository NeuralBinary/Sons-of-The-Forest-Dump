using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class DemoScriptTriggerPath : MonoBehaviour
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA2E8F0", Offset = "0xA2CEF0", VA = "0x180A2E8F0")]
		private void Start()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA2E910", Offset = "0xA2CF10", VA = "0x180A2E910")]
		private void Update()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA2EE20", Offset = "0xA2D420", VA = "0x180A2EE20")]
		public DemoScriptTriggerPath()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		public LightningSplineScript Script;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		public Toggle SplineToggle;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Vector3> points;
	}
}
