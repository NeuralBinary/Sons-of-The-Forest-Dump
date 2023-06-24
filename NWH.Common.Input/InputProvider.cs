using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Input
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public abstract class InputProvider : MonoBehaviour
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26EE030", Offset = "0x26EC630", VA = "0x1826EE030", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x26EE0F0", Offset = "0x26EC6F0", VA = "0x1826EE0F0", Slot = "5")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x600000F")]
		public static int CombinedInput<T>(Func<T, int> selector) where T : InputProvider
		{
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x6000010")]
		public static float CombinedInput<T>(Func<T, float> selector) where T : InputProvider
		{
			return 0f;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x6000011")]
		public static bool CombinedInput<T>(Func<T, bool> selector) where T : InputProvider
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x6000012")]
		public static Vector2 CombinedInput<T>(Func<T, Vector2> selector) where T : InputProvider
		{
			return default(Vector2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected InputProvider()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public static List<InputProvider> Instances;
	}
}
