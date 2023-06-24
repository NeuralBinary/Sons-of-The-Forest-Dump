using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public static class BoltScenes
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7B47E0", Offset = "0x7B2DE0", VA = "0x1807B47E0")]
	public static void AddScene(short prefix, short id, string name)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public static IEnumerable<string> AllScenes
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x7B48F0", Offset = "0x7B2EF0", VA = "0x1807B48F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly Dictionary<string, int> nameLookup;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly Dictionary<int, string> indexLookup;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	public const string Splash = "Splash";

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	public const string SonsTitleScene = "SonsTitleScene";

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	public const string SonsMainLoading = "SonsMainLoading";

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	public const string SonsOptionsMenu = "SonsOptionsMenu";

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	public const string MultiplayerMenu = "MultiplayerMenu";

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	public const string MultiplayerHostMenu = "MultiplayerHostMenu";

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	public const string BlankScene = "BlankScene";

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	public const string SonsMain = "SonsMain";

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x400020B")]
	public const string SonsMainReflectionProbeBake = "SonsMainReflectionProbeBake";

	// Token: 0x0400020C RID: 524
	[Token(Token = "0x400020C")]
	public const string SonsAnimals = "SonsAnimals";

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x400020D")]
	public const string Site02RealtimeGreebles = "Site02RealtimeGreebles";

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	public const string SonsStorySpots = "SonsStorySpots";

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	public const string SonsMainCharacterSpawns = "SonsMainCharacterSpawns";

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	public const string Site02StreamsAndLakes = "Site02StreamsAndLakes";

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	public const string ObiPluginWarmUp = "ObiPluginWarmUp";

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	public const string SonsCaveA = "SonsCaveA";

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	public const string SonsCaveB = "SonsCaveB";

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	public const string SonsCaveC = "SonsCaveC";

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	public const string SonsCaveD = "SonsCaveD";

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	public const string IceCaves = "IceCaves";

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	public const string Bunker_A = "Bunker_A";

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x4000218")]
	public const string Bunker_B = "Bunker_B";

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	public const string Bunker_C = "Bunker_C";

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	public const string BunkerEntertainment = "BunkerEntertainment";

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	public const string BunkerFoodAndDining = "BunkerFoodAndDining";

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	public const string BunkerResidential = "BunkerResidential";

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	public const string BunkerLuxury = "BunkerLuxury";

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	public const string SonsCreditsScene = "SonsCreditsScene";

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	public const string FrisoTest = "FrisoTest";

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	public const string Jon_TestScene = "Jon_TestScene";

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	public const string DedicatedServerBootstrap = "DedicatedServerBootstrap";
}
