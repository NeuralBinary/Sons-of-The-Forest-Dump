using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public interface IMaeAnimator
	{
		// Token: 0x060000F7 RID: 247
		[Token(Token = "0x60000F7")]
		Animator GetAnimator();

		// Token: 0x060000F8 RID: 248
		[Token(Token = "0x60000F8")]
		Animator GetTargetAnimator();

		// Token: 0x060000F9 RID: 249
		[Token(Token = "0x60000F9")]
		void MoveToTarget(MoveToParams moveToParams);

		// Token: 0x060000FA RID: 250
		[Token(Token = "0x60000FA")]
		void MoveToCover(MoveAligned.AlignType alignType, MoveAlignedParams moveAlignedParams);

		// Token: 0x060000FB RID: 251
		[Token(Token = "0x60000FB")]
		void MoveRandom(SpeedRangeSet speed, float stopDistance, Vector2 minMaxDistance, Vector2 minMaxDirection, MoveRandomDirection direction, MoveRandomBounds boundsType, Action completedCallback, Action interruptedCallback);

		// Token: 0x060000FC RID: 252
		[Token(Token = "0x60000FC")]
		void MoveAlignedToTarget(MoveAlignedParams moveAlignedParams, MoveTargetType targetType);

		// Token: 0x060000FD RID: 253
		[Token(Token = "0x60000FD")]
		void FollowTarget(SpeedRangeSet speed, Action complete, Action interrupted);

		// Token: 0x060000FE RID: 254
		[Token(Token = "0x60000FE")]
		void StartSnapToTarget(SnapToParams snapParams);

		// Token: 0x060000FF RID: 255
		[Token(Token = "0x60000FF")]
		void EndSnapToTarget();

		// Token: 0x06000100 RID: 256
		[Token(Token = "0x6000100")]
		void SnapToTarget(float factor);

		// Token: 0x06000101 RID: 257
		[Token(Token = "0x6000101")]
		void HoldAtTarget();

		// Token: 0x06000102 RID: 258
		[Token(Token = "0x6000102")]
		void AlignTo(AlignToParams alignToParams);

		// Token: 0x06000103 RID: 259
		[Token(Token = "0x6000103")]
		void BeginInteraction(Action completedCallback, Action interruptedCallback);

		// Token: 0x06000104 RID: 260
		[Token(Token = "0x6000104")]
		void Interact(float deltaTime, Action completedCallback, Action interruptedCallback);

		// Token: 0x06000105 RID: 261
		[Token(Token = "0x6000105")]
		void EndInteraction(Action completedCallback, Action interruptedCallback);

		// Token: 0x06000106 RID: 262
		[Token(Token = "0x6000106")]
		void ApplyImpactData(int direction, int impactType, int subImpactType, int location, float force, bool overrideData);

		// Token: 0x06000107 RID: 263
		[Token(Token = "0x6000107")]
		void SetShouldChangeState();

		// Token: 0x06000108 RID: 264
		[Token(Token = "0x6000108")]
		void FollowFlightPath(FlightPath.PathType pathType, FlightPathParams flightParams);

		// Token: 0x06000109 RID: 265
		[Token(Token = "0x6000109")]
		void FollowSurfacePath(SurfacePathParams pathParams);

		// Token: 0x0600010A RID: 266
		[Token(Token = "0x600010A")]
		void GenerateEventPrefab(GameObject eventPrefab, bool proxyTargetIsLastStimuli, string targetPosition, GenerateEvent.AttachType attachType, bool isUnique);

		// Token: 0x0600010B RID: 267
		[Token(Token = "0x600010B")]
		void SetAttention(bool overrideActive, int frequency, int expression);

		// Token: 0x0600010C RID: 268
		[Token(Token = "0x600010C")]
		void SetRagdoll(bool setValue);

		// Token: 0x0600010D RID: 269
		[Token(Token = "0x600010D")]
		void SendMessageToTarget(MessageTarget.Target target, MessageTarget.Message message);

		// Token: 0x0600010E RID: 270
		[Token(Token = "0x600010E")]
		bool IsInSwimmableWater();

		// Token: 0x0600010F RID: 271
		[Token(Token = "0x600010F")]
		bool IsOnLand();

		// Token: 0x06000110 RID: 272
		[Token(Token = "0x6000110")]
		bool CanEndBlock();
	}
}
