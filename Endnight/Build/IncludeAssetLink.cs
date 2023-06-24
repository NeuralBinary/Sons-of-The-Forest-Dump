using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Build
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[CreateAssetMenu(fileName = "IncludeAsset", menuName = "Include Asset")]
	public class IncludeAssetLink : ScriptableObject
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000047")]
		public IEnumerable<UnityEngine.Object> GetObjects
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public IncludeAssetLink()
		{
		}

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEngine.Object[] _linkedObjects;
	}
}
