using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[AddComponentMenu("Endnight/Utilities/FollowActiveWorldLocation")]
	public class FollowActiveWorldLocation : MonoBehaviour
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA737B0", Offset = "0xA71DB0", VA = "0x180A737B0")]
		private void Update()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FollowActiveWorldLocation()
		{
		}

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _position;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _rotation;
	}
}
