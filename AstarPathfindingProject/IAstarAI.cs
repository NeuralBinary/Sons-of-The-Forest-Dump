using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public interface IAstarAI
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000122 RID: 290
		// (set) Token: 0x06000123 RID: 291
		[Token(Token = "0x1700004C")]
		float radius { [Token(Token = "0x6000122")] get; [Token(Token = "0x6000123")] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000124 RID: 292
		// (set) Token: 0x06000125 RID: 293
		[Token(Token = "0x1700004D")]
		float height { [Token(Token = "0x6000124")] get; [Token(Token = "0x6000125")] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000126 RID: 294
		[Token(Token = "0x1700004E")]
		Vector3 position { [Token(Token = "0x6000126")] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000127 RID: 295
		// (set) Token: 0x06000128 RID: 296
		[Token(Token = "0x1700004F")]
		Quaternion rotation { [Token(Token = "0x6000127")] get; [Token(Token = "0x6000128")] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000129 RID: 297
		// (set) Token: 0x0600012A RID: 298
		[Token(Token = "0x17000050")]
		float maxSpeed { [Token(Token = "0x6000129")] get; [Token(Token = "0x600012A")] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012B RID: 299
		[Token(Token = "0x17000051")]
		Vector3 velocity { [Token(Token = "0x600012B")] get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012C RID: 300
		[Token(Token = "0x17000052")]
		Vector3 desiredVelocity { [Token(Token = "0x600012C")] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012D RID: 301
		[Token(Token = "0x17000053")]
		float remainingDistance { [Token(Token = "0x600012D")] get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012E RID: 302
		[Token(Token = "0x17000054")]
		bool reachedDestination { [Token(Token = "0x600012E")] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012F RID: 303
		[Token(Token = "0x17000055")]
		bool reachedEndOfPath { [Token(Token = "0x600012F")] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000130 RID: 304
		// (set) Token: 0x06000131 RID: 305
		[Token(Token = "0x17000056")]
		Vector3 destination { [Token(Token = "0x6000130")] get; [Token(Token = "0x6000131")] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000132 RID: 306
		// (set) Token: 0x06000133 RID: 307
		[Token(Token = "0x17000057")]
		bool canSearch { [Token(Token = "0x6000132")] get; [Token(Token = "0x6000133")] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000134 RID: 308
		// (set) Token: 0x06000135 RID: 309
		[Token(Token = "0x17000058")]
		bool canMove { [Token(Token = "0x6000134")] get; [Token(Token = "0x6000135")] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000136 RID: 310
		[Token(Token = "0x17000059")]
		bool hasPath { [Token(Token = "0x6000136")] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000137 RID: 311
		[Token(Token = "0x1700005A")]
		bool pathPending { [Token(Token = "0x6000137")] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000138 RID: 312
		// (set) Token: 0x06000139 RID: 313
		[Token(Token = "0x1700005B")]
		bool isStopped { [Token(Token = "0x6000138")] get; [Token(Token = "0x6000139")] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013A RID: 314
		[Token(Token = "0x1700005C")]
		Vector3 steeringTarget { [Token(Token = "0x600013A")] get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013B RID: 315
		// (set) Token: 0x0600013C RID: 316
		[Token(Token = "0x1700005D")]
		Action onSearchPath { [Token(Token = "0x600013B")] get; [Token(Token = "0x600013C")] set; }

		// Token: 0x0600013D RID: 317
		[Token(Token = "0x600013D")]
		void GetRemainingPath(List<Vector3> buffer, out bool stale);

		// Token: 0x0600013E RID: 318
		[Token(Token = "0x600013E")]
		void SearchPath();

		// Token: 0x0600013F RID: 319
		[Token(Token = "0x600013F")]
		void SetPath(Path path, bool updateDestinationFromPath = true);

		// Token: 0x06000140 RID: 320
		[Token(Token = "0x6000140")]
		void Teleport(Vector3 newPosition, bool clearPath = true);

		// Token: 0x06000141 RID: 321
		[Token(Token = "0x6000141")]
		void Move(Vector3 deltaPosition);

		// Token: 0x06000142 RID: 322
		[Token(Token = "0x6000142")]
		void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

		// Token: 0x06000143 RID: 323
		[Token(Token = "0x6000143")]
		void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation);
	}
}
