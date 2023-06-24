using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[RequireComponent(typeof(ObiActor))]
	public class SetPhase : MonoBehaviour
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2805D00", Offset = "0x2804300", VA = "0x182805D00")]
		private void Awake()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x2805DB0", Offset = "0x28043B0", VA = "0x182805DB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x2805E60", Offset = "0x2804460", VA = "0x182805E60")]
		private void OnValidate()
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x2805E90", Offset = "0x2804490", VA = "0x182805E90")]
		private void Set(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SetPhase()
		{
		}

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x20")]
		public int phase;
	}
}
