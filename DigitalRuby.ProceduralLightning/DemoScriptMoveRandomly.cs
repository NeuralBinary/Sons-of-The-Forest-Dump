using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class DemoScriptMoveRandomly : MonoBehaviour
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Start()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA2DF60", Offset = "0xA2C560", VA = "0x180A2DF60")]
		private void Update()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA2E5A0", Offset = "0xA2CBA0", VA = "0x180A2E5A0")]
		public DemoScriptMoveRandomly()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x20")]
		private float elapsed;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 startStartPos;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 startEndPos;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 endStartPos;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 endEndPos;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The transform to move randomly.")]
		public Transform Transform1;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("The transform to move randomly.")]
		public Transform Transform2;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 5f)]
		[Tooltip("How long until the start and end objects change positions again. Set to 0 to not move the objects.")]
		public float MoveTimeSeconds;
	}
}
