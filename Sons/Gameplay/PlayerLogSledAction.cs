using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x0200081D RID: 2077
	[Token(Token = "0x200081D")]
	[AddComponentMenu("Sons/Gameplay/PlayerLogSledAction")]
	public class PlayerLogSledAction : MonoBehaviour, IKnockDownReceiver
	{
		// Token: 0x06003A4A RID: 14922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x3567130", Offset = "0x3565730", VA = "0x183567130")]
		private void StopAudio()
		{
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4B")]
		[Address(RVA = "0x35672D0", Offset = "0x35658D0", VA = "0x1835672D0")]
		private void UpdateAudio()
		{
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4C")]
		[Address(RVA = "0x3567700", Offset = "0x3565D00", VA = "0x183567700")]
		private void UpdatePushAudioSpeed()
		{
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x35678B0", Offset = "0x3565EB0", VA = "0x1835678B0")]
		private bool SetupSledEventInstance()
		{
			return default(bool);
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079A")]
		public Transform TargetTransform
		{
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x3567A00", Offset = "0x3566000", VA = "0x183567A00")]
		public void Initialize(LogSledController logSledController)
		{
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x3568570", Offset = "0x3566B70", VA = "0x183568570")]
		private void InitializeConnectedTransform()
		{
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x3568600", Offset = "0x3566C00", VA = "0x183568600")]
		private static void SetConstraintSource(UnityEngine.Animations.IConstraint sourceConstraint, Transform targetTransform)
		{
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x35688C0", Offset = "0x3566EC0", VA = "0x1835688C0")]
		private void AlignPlayerTargetsToWorldSled(Transform sledTransform)
		{
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00011D78 File Offset: 0x0000FF78
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x3568EF0", Offset = "0x35674F0", VA = "0x183568EF0")]
		private static Quaternion CalculatePlayerAlignRotation(LogSledController logSledController)
		{
			return default(Quaternion);
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x3569000", Offset = "0x3567600", VA = "0x183569000")]
		private void SendNetworkConnectEvent()
		{
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x3569210", Offset = "0x3567810", VA = "0x183569210")]
		private void SetupBindings()
		{
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x3569710", Offset = "0x3567D10", VA = "0x183569710")]
		private void ClearBindings()
		{
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x3569D20", Offset = "0x3568320", VA = "0x183569D20")]
		private void SetupInteractBinding(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x3569E90", Offset = "0x3568490", VA = "0x183569E90")]
		private void OnDisconnectAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x3569EC0", Offset = "0x35684C0", VA = "0x183569EC0")]
		public void TriggerDisconnect()
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x3569FE0", Offset = "0x35685E0", VA = "0x183569FE0")]
		private void DisconnectViaSled(LogSledController logSledController)
		{
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x356A110", Offset = "0x3568710", VA = "0x18356A110")]
		private void TriggerDisconnectInternal()
		{
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0x356A680", Offset = "0x3568C80", VA = "0x18356A680")]
		private void DisconnectIk()
		{
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x356A7A0", Offset = "0x3568DA0", VA = "0x18356A7A0")]
		private void DisconnectLocalPlayer()
		{
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x356ACF0", Offset = "0x35692F0", VA = "0x18356ACF0")]
		private void SendNetworkReleaseEvent()
		{
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x356AEF0", Offset = "0x35694F0", VA = "0x18356AEF0")]
		private void Update()
		{
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x356B040", Offset = "0x3569640", VA = "0x18356B040")]
		private void UpdateTargetTransform(Transform raycastOriginTransform, bool instant = false)
		{
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x356C0D0", Offset = "0x356A6D0", VA = "0x18356C0D0")]
		private void UpdateAnimationParams()
		{
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x356C290", Offset = "0x356A890", VA = "0x18356C290")]
		private Quaternion ClampXRotation(Quaternion stateHandlePivotRotationGoal, float definitionMaxHandlePivotRotationX)
		{
			return default(Quaternion);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x356C380", Offset = "0x356A980", VA = "0x18356C380")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A64")]
		[Address(RVA = "0x356C650", Offset = "0x356AC50", VA = "0x18356C650")]
		private void ApplyHandlePivotRotationGroundOffset()
		{
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A65")]
		[Address(RVA = "0x356C930", Offset = "0x356AF30", VA = "0x18356C930")]
		private void UpdatePlayerGroundOffset()
		{
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x356D110", Offset = "0x356B710", VA = "0x18356D110")]
		private float CalculatePlayerGroundHeightOffset(Transform relativeTransform, Vector3 rayOrigin, out Vector3 hitPoint, float maxDistance, float castRadius)
		{
			return 0f;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x356D4A0", Offset = "0x356BAA0", VA = "0x18356D4A0")]
		private void ApplyStaminaCost()
		{
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x356D4E0", Offset = "0x356BAE0", VA = "0x18356D4E0")]
		private void ApplyPlayerGroundingForce()
		{
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x356D6F0", Offset = "0x356BCF0", VA = "0x18356D6F0")]
		private void MovePlayer()
		{
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x356D700", Offset = "0x356BD00", VA = "0x18356D700")]
		private void HandleStrafeMovement()
		{
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x356D950", Offset = "0x356BF50", VA = "0x18356D950")]
		private void HandleForwardMovement()
		{
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x356DF10", Offset = "0x356C510", VA = "0x18356DF10")]
		private Vector3 CalculateSmoothedForwardDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x356E260", Offset = "0x356C860", VA = "0x18356E260")]
		private void ApplyVelocityDampening()
		{
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x356E4F0", Offset = "0x356CAF0", VA = "0x18356E4F0")]
		private void UpdateInput()
		{
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x355DAF0", Offset = "0x355C0F0", VA = "0x18355DAF0")]
		private static Vector2 GetMovementInput()
		{
			return default(Vector2);
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x356E560", Offset = "0x356CB60", VA = "0x18356E560")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x356E990", Offset = "0x356CF90", VA = "0x18356E990")]
		private bool CalculateLogSledTargetPosition(Transform raycastOriginTransform, out Vector3 position, out Vector3 normal)
		{
			return default(bool);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x356FC50", Offset = "0x356E250", VA = "0x18356FC50")]
		private void ClampOffsetFromAverage(ref Vector3 hitPoint, ref float offsetFromAverage, Vector3 averageNormal, float minOffset, float maxOffset)
		{
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x356FD10", Offset = "0x356E310", VA = "0x18356FD10")]
		public static float SignedAngleBetweenUpVectors(Vector3 up1, Vector3 up2, Vector3 forward)
		{
			return 0f;
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x356FED0", Offset = "0x356E4D0", VA = "0x18356FED0")]
		private RaycastHit GetClosestHit(RaycastHit[] raycastHits, int hitCount, Vector3 worldOffset)
		{
			return default(RaycastHit);
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x3570180", Offset = "0x356E780", VA = "0x183570180")]
		private static float CalculateOffsetAlongNormal(Vector3 pointA, Vector3 pointB, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x35701F0", Offset = "0x356E7F0", VA = "0x1835701F0")]
		private List<List<Vector3>> ConvertToTriangles(List<Vector3> hitPoints)
		{
			return null;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x3570E80", Offset = "0x356F480", VA = "0x183570E80")]
		private Vector3 CalculateNormalFromPoints(List<List<Vector3>> triangles)
		{
			return default(Vector3);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x3571350", Offset = "0x356F950", VA = "0x183571350")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A79")]
		[Address(RVA = "0x35715B0", Offset = "0x356FBB0", VA = "0x1835715B0")]
		private void UpdateIsInAir()
		{
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x35716F0", Offset = "0x356FCF0", VA = "0x1835716F0")]
		private bool ShouldForceDisconnect()
		{
			return default(bool);
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x3571810", Offset = "0x356FE10", VA = "0x183571810")]
		private bool IsInAir()
		{
			return default(bool);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x3571850", Offset = "0x356FE50", VA = "0x183571850")]
		private void ClearAccumulatedMovement()
		{
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x3569E90", Offset = "0x3568490", VA = "0x183569E90", Slot = "4")]
		public void OnKnockDownStarted()
		{
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x35718D0", Offset = "0x356FED0", VA = "0x1835718D0")]
		public PlayerLogSledAction()
		{
		}

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		private const string LogSledTagString = "LogSled";

		// Token: 0x040031B8 RID: 12728
		[Token(Token = "0x40031B8")]
		private const string SpeedParamString = "speed";

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		private const string TempRayObjectName = "_tempRayTransform_";

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		private const string TempRayParentName = "_tempRayTransformParent_";

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _targetTransform;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _handlePivotTransform;

		// Token: 0x040031BD RID: 12733
		[Token(Token = "0x40031BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _targetTransformRaycastOrigin;

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _networkProxyConnectedTransform;

		// Token: 0x040031BF RID: 12735
		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x40")]
		private LogSledControllerDefinition _logSledControllerDefinition;

		// Token: 0x040031C0 RID: 12736
		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x48")]
		private LogSledControllerState _state;

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _targetTransformBaseLocalPosition;

		// Token: 0x040031C2 RID: 12738
		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x5C")]
		private float _targetTransformBaseDistance;

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _lastTargetTransformPosition;

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _lastTargetTransformNormal;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x78")]
		private RaycastHit[] _raycastHits;

		// Token: 0x040031C6 RID: 12742
		[Token(Token = "0x40031C6")]
		[FieldOffset(Offset = "0x80")]
		private GroundedDetector _groundedDetector;

		// Token: 0x040031C7 RID: 12743
		[Token(Token = "0x40031C7")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector3> _hitPointsBuffer;

		// Token: 0x040031C8 RID: 12744
		[Token(Token = "0x40031C8")]
		[FieldOffset(Offset = "0x90")]
		private List<List<Vector3>> _previousTrianglesResult;
	}
}
