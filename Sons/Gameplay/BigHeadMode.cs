using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	[AddComponentMenu("Sons/Gameplay/BigHeadMode")]
	public class BigHeadMode : MonoBehaviour
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x349A390", Offset = "0x3498990", VA = "0x18349A390")]
		private void Awake()
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x349A4A0", Offset = "0x3498AA0", VA = "0x18349A4A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003237")]
		[Address(RVA = "0x349A510", Offset = "0x3498B10", VA = "0x18349A510")]
		private void SetBigHeadMode(bool enable)
		{
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003238")]
		[Address(RVA = "0x349A710", Offset = "0x3498D10", VA = "0x18349A710")]
		public BigHeadMode()
		{
		}

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scale;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _defaultScale;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasApplied;
	}
}
