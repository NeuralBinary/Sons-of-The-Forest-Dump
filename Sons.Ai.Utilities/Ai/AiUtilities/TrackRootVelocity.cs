using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ai.AiUtilities
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class TrackRootVelocity
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2A8CB10", Offset = "0x2A8B110", VA = "0x182A8CB10")]
		public void Clear()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2A8CBC0", Offset = "0x2A8B1C0", VA = "0x182A8CBC0")]
		public void TrackVelocity(Vector3 moveDelta, float deltaTime)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2A8CC40", Offset = "0x2A8B240", VA = "0x182A8CC40")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2A8CDE0", Offset = "0x2A8B3E0", VA = "0x182A8CDE0")]
		public TrackRootVelocity()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const int PreviousFrames = 6;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private int _currentFrame;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _previousRootPos;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private readonly Vector3[] _previousRootVel;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		private readonly float[] _previousTimes;
	}
}
