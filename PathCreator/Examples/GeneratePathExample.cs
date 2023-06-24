using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Examples
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[RequireComponent(typeof(PathCreator))]
	public class GeneratePathExample : MonoBehaviour
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x28362C0", Offset = "0x28348C0", VA = "0x1828362C0")]
		private void Start()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public GeneratePathExample()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		public bool closedLoop;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] waypoints;
	}
}
