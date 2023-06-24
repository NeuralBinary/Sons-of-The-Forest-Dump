using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Examples
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class PathFollower : MonoBehaviour
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x28364E0", Offset = "0x2834AE0", VA = "0x1828364E0")]
		private void Start()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x28366C0", Offset = "0x2834CC0", VA = "0x1828366C0")]
		private void Update()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x28369D0", Offset = "0x2834FD0", VA = "0x1828369D0")]
		private void OnPathChanged()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2836B60", Offset = "0x2835160", VA = "0x182836B60")]
		public PathFollower()
		{
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		public PathCreator pathCreator;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		public EndOfPathInstruction endOfPathInstruction;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x2C")]
		public float speed;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x30")]
		public float distanceTravelled;
	}
}
