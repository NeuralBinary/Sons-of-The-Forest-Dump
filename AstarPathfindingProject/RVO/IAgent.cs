using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public interface IAgent
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000A5F RID: 2655
		// (set) Token: 0x06000A60 RID: 2656
		[Token(Token = "0x17000159")]
		Vector2 Position { [Token(Token = "0x6000A5F")] get; [Token(Token = "0x6000A60")] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000A61 RID: 2657
		// (set) Token: 0x06000A62 RID: 2658
		[Token(Token = "0x1700015A")]
		float ElevationCoordinate { [Token(Token = "0x6000A61")] get; [Token(Token = "0x6000A62")] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A63 RID: 2659
		[Token(Token = "0x1700015B")]
		Vector2 CalculatedTargetPoint { [Token(Token = "0x6000A63")] get; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A64 RID: 2660
		[Token(Token = "0x1700015C")]
		float CalculatedSpeed { [Token(Token = "0x6000A64")] get; }

		// Token: 0x06000A65 RID: 2661
		[Token(Token = "0x6000A65")]
		void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed);

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A66 RID: 2662
		// (set) Token: 0x06000A67 RID: 2663
		[Token(Token = "0x1700015D")]
		bool Locked { [Token(Token = "0x6000A66")] get; [Token(Token = "0x6000A67")] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A68 RID: 2664
		// (set) Token: 0x06000A69 RID: 2665
		[Token(Token = "0x1700015E")]
		float Radius { [Token(Token = "0x6000A68")] get; [Token(Token = "0x6000A69")] set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A6A RID: 2666
		// (set) Token: 0x06000A6B RID: 2667
		[Token(Token = "0x1700015F")]
		float Height { [Token(Token = "0x6000A6A")] get; [Token(Token = "0x6000A6B")] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000A6C RID: 2668
		// (set) Token: 0x06000A6D RID: 2669
		[Token(Token = "0x17000160")]
		float AgentTimeHorizon { [Token(Token = "0x6000A6C")] get; [Token(Token = "0x6000A6D")] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000A6E RID: 2670
		// (set) Token: 0x06000A6F RID: 2671
		[Token(Token = "0x17000161")]
		float ObstacleTimeHorizon { [Token(Token = "0x6000A6E")] get; [Token(Token = "0x6000A6F")] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000A70 RID: 2672
		// (set) Token: 0x06000A71 RID: 2673
		[Token(Token = "0x17000162")]
		int MaxNeighbours { [Token(Token = "0x6000A70")] get; [Token(Token = "0x6000A71")] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A72 RID: 2674
		[Token(Token = "0x17000163")]
		int NeighbourCount { [Token(Token = "0x6000A72")] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A73 RID: 2675
		// (set) Token: 0x06000A74 RID: 2676
		[Token(Token = "0x17000164")]
		RVOLayer Layer { [Token(Token = "0x6000A73")] get; [Token(Token = "0x6000A74")] set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A75 RID: 2677
		// (set) Token: 0x06000A76 RID: 2678
		[Token(Token = "0x17000165")]
		RVOLayer CollidesWith { [Token(Token = "0x6000A75")] get; [Token(Token = "0x6000A76")] set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000A77 RID: 2679
		// (set) Token: 0x06000A78 RID: 2680
		[Token(Token = "0x17000166")]
		bool DebugDraw { [Token(Token = "0x6000A77")] get; [Token(Token = "0x6000A78")] set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000A79 RID: 2681
		[Token(Token = "0x17000167")]
		[Obsolete]
		List<ObstacleVertex> NeighbourObstacles { [Token(Token = "0x6000A79")] get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000A7A RID: 2682
		// (set) Token: 0x06000A7B RID: 2683
		[Token(Token = "0x17000168")]
		float Priority { [Token(Token = "0x6000A7A")] get; [Token(Token = "0x6000A7B")] set; }

		// Token: 0x17000169 RID: 361
		// (set) Token: 0x06000A7C RID: 2684
		[Token(Token = "0x17000169")]
		Action PreCalculationCallback { [Token(Token = "0x6000A7C")] set; }

		// Token: 0x06000A7D RID: 2685
		[Token(Token = "0x6000A7D")]
		void SetCollisionNormal(Vector2 normal);

		// Token: 0x06000A7E RID: 2686
		[Token(Token = "0x6000A7E")]
		void ForceSetVelocity(Vector2 velocity);
	}
}
