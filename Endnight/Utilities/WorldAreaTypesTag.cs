using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class WorldAreaTypesTag : MonoBehaviour
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x1700001C")]
		public WorldAreaTypes WorldAreaType
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return WorldAreaTypes.Outside;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA8E340", Offset = "0xA8C940", VA = "0x180A8E340")]
		private void Awake()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WorldAreaTypesTag()
		{
		}

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldAreaTypes _worldAreaType;
	}
}
