using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class PoolingManager : MonoBehaviour
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000003")]
		public static PoolingManager instance
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x90A220", Offset = "0x908820", VA = "0x18090A220")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		public void AddObject<T>(T obj) where T : PoolingObject
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x90A4F0", Offset = "0x908AF0", VA = "0x18090A4F0")]
		public PoolingObject Get(GameObject ID, Vector3 position)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x90AA00", Offset = "0x909000", VA = "0x18090AA00")]
		public PoolingManager()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, Queue<PoolingObject>> Pool;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		private static PoolingManager _instance;
	}
}
