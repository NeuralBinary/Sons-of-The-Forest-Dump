using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	[AddComponentMenu("Physics/Obi/Obi Late Updater", 802)]
	public class ObiLateUpdater : ObiUpdater
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x27F27C0", Offset = "0x27F0DC0", VA = "0x1827F27C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x27F27E0", Offset = "0x27F0DE0", VA = "0x1827F27E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x27F29D0", Offset = "0x27F0FD0", VA = "0x1827F29D0")]
		public ObiLateUpdater()
		{
		}

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Smoothing factor fo the timestep (smoothDelta). Values closer to 1 will yield stabler simulation, but it will be off-sync with rendering.")]
		[Range(0f, 1f)]
		public float deltaSmoothing;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Target timestep used to advance the simulation. The updater will interpolate this value with Time.deltaTime to find the actual timestep used for each frame.")]
		private float smoothDelta;
	}
}
