using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	[AddComponentMenu("Sons/Stimuli/Drag Log Stimuli")]
	public class DragLogStimuli : InteractStimuli
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x2B9CA80", Offset = "0x2B9B080", VA = "0x182B9CA80")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x2B9CAB0", Offset = "0x2B9B0B0", VA = "0x182B9CAB0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x2B9CB30", Offset = "0x2B9B130", VA = "0x182B9CB30")]
		private void Update()
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		public DragLogStimuli()
		{
		}

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _dragLocation;
	}
}
