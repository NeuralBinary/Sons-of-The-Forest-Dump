using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.FieldOfView;
using Sons.Gameplay;
using Sons.Gameplay.Swimming;
using Sons.Inventory;
using Sons.Items.Core;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
[DefaultExecutionOrder(200)]
[AddComponentMenu("TheForest/Player Animator Control")]
public class PlayerAnimatorControl : MonoBehaviour
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000921 RID: 2337 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x17000121")]
	public bool DoingGroundChop
	{
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x3691BB0", Offset = "0x36901B0", VA = "0x183691BB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000922 RID: 2338 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x17000122")]
	public bool HorizontalMovement
	{
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x3691BC0", Offset = "0x36901C0", VA = "0x183691BC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000923 RID: 2339 RVA: 0x00004638 File Offset: 0x00002838
	[Token(Token = "0x17000123")]
	public bool VerticalMovement
	{
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x3691BE0", Offset = "0x36901E0", VA = "0x183691BE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000924 RID: 2340 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x17000124")]
	public bool IsMeleeWeaponControllerEnabled
	{
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x69B260", Offset = "0x699860", VA = "0x18069B260")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000925 RID: 2341 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x17000125")]
	public float CurrentMovementSpeed
	{
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000926 RID: 2342 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x17000126")]
	public bool DisableAutoUpperBodyLayer
	{
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x3691C00", Offset = "0x3690200", VA = "0x183691C00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x3691C10", Offset = "0x3690210", VA = "0x183691C10")]
	public bool SetDisableAutoUpperBodyLayer(bool value)
	{
		return default(bool);
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000928 RID: 2344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000127")]
	public animEventsManager AnimEventsManager
	{
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x3691C20", Offset = "0x3690220", VA = "0x183691C20")]
	public bool IsConnectedToLogSled()
	{
		return default(bool);
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x3691C30", Offset = "0x3690230", VA = "0x183691C30")]
	public void SetConnectedToLogSled(bool value)
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x3691C40", Offset = "0x3690240", VA = "0x183691C40")]
	private void Awake()
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x3692080", Offset = "0x3690680", VA = "0x183692080")]
	private void Start()
	{
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x3692150", Offset = "0x3690750", VA = "0x183692150")]
	private void OnEnable()
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x3692470", Offset = "0x3690A70", VA = "0x183692470")]
	private void OnDisable()
	{
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x3692790", Offset = "0x3690D90", VA = "0x183692790")]
	private void OnStopSlide()
	{
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x36927B0", Offset = "0x3690DB0", VA = "0x1836927B0")]
	private void OnStartSlide()
	{
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x36927D0", Offset = "0x3690DD0", VA = "0x1836927D0")]
	private void Update()
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x3693AE0", Offset = "0x36920E0", VA = "0x183693AE0")]
	private static bool WasGrounded()
	{
		return default(bool);
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x3693B50", Offset = "0x3692150", VA = "0x183693B50")]
	public void UpdatePlayerVelocity(Vector2 movementInput)
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x3693D40", Offset = "0x3692340", VA = "0x183693D40")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x36942F0", Offset = "0x36928F0", VA = "0x1836942F0")]
	public bool IsMidSlideDown()
	{
		return default(bool);
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x3694300", Offset = "0x3692900", VA = "0x183694300")]
	public bool IsMidHitReact()
	{
		return default(bool);
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x3694360", Offset = "0x3692960", VA = "0x183694360")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x36946A0", Offset = "0x3692CA0", VA = "0x1836946A0")]
	private bool HasClampedSpine()
	{
		return default(bool);
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x3694800", Offset = "0x3692E00", VA = "0x183694800")]
	private void UpdateWallPusherOffset()
	{
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x3694C10", Offset = "0x3693210", VA = "0x183694C10")]
	public void SetWallOffset(float distance)
	{
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x3695040", Offset = "0x3693640", VA = "0x183695040")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x36950D0", Offset = "0x36936D0", VA = "0x1836950D0")]
	private void OnAnimatorMove()
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x36951A0", Offset = "0x36937A0", VA = "0x1836951A0")]
	private void OnValidate()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x36951B0", Offset = "0x36937B0", VA = "0x1836951B0")]
	private void UpdateComponents()
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093F")]
	private void UpdateComponentInParent<T>(ref T target, Component targetComponent) where T : Component
	{
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000940")]
	private void UpdateComponent<T>(ref T target, Component targetComponent) where T : Component
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000941")]
	private void UpdateComponent<T>(ref T target, GameObject targetGameObject) where T : Component
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x36954B0", Offset = "0x3693AB0", VA = "0x1836954B0")]
	public void RegisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
	{
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x36955A0", Offset = "0x3693BA0", VA = "0x1836955A0")]
	public void UnregisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
	{
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x3695690", Offset = "0x3693C90", VA = "0x183695690")]
	public void RegisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x3695780", Offset = "0x3693D80", VA = "0x183695780")]
	public void UnregisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00004728 File Offset: 0x00002928
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x3695870", Offset = "0x3693E70", VA = "0x183695870")]
	public bool HasLayerActivator(int layer)
	{
		return default(bool);
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x36959A0", Offset = "0x3693FA0", VA = "0x1836959A0")]
	public string GetLayerActivatorLog()
	{
		return null;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00004740 File Offset: 0x00002940
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x3695A90", Offset = "0x3694090", VA = "0x183695A90")]
	private bool IsLeftHandBusy()
	{
		return default(bool);
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x6000949")]
	[Address(RVA = "0x3695AD0", Offset = "0x36940D0", VA = "0x183695AD0")]
	private bool IsThirdPerson()
	{
		return default(bool);
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x3695AE0", Offset = "0x36940E0", VA = "0x183695AE0")]
	public void StopSmoothResetCameraYPosition()
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x3695C40", Offset = "0x3694240", VA = "0x183695C40")]
	public void SmoothResetCameraYPosition()
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x3695CF0", Offset = "0x36942F0", VA = "0x183695CF0")]
	private static IEnumerator SmoothResetCameraYPositionRoutine()
	{
		return null;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x3695D30", Offset = "0x3694330", VA = "0x183695D30")]
	private void UpdateCameraAngleParams(float normCamXOld)
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x3696770", Offset = "0x3694D70", VA = "0x183696770")]
	private void UpdatePlayerVelocity(float oldHSpeed, float oldVSpeed, float oldOSpeed, Vector2 movementInput)
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x3696D10", Offset = "0x3695310", VA = "0x183696D10")]
	private Vector3 CalculateBaseLocalVelocity(Vector2 input)
	{
		return default(Vector3);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x3696EF0", Offset = "0x36954F0", VA = "0x183696EF0")]
	public static Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x3696FC0", Offset = "0x36955C0", VA = "0x183696FC0")]
	private void ClearFullBodyWeightFromTransition()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x3697140", Offset = "0x3695740", VA = "0x183697140")]
	private void UpdateAnimLayerWeights()
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x3697CE0", Offset = "0x36962E0", VA = "0x183697CE0")]
	public void OnDeath()
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x3697DC0", Offset = "0x36963C0", VA = "0x183697DC0")]
	public bool IsInDeathState()
	{
		return default(bool);
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x000047B8 File Offset: 0x000029B8
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x3697E20", Offset = "0x3696420", VA = "0x183697E20")]
	private bool CheckDeathState()
	{
		return default(bool);
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x3697ED0", Offset = "0x36964D0", VA = "0x183697ED0")]
	private void UpdateDeathState()
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x000047D0 File Offset: 0x000029D0
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x3698AA0", Offset = "0x36970A0", VA = "0x183698AA0")]
	private bool IsForceUpperBodyTag(int tagHash)
	{
		return default(bool);
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x3698B70", Offset = "0x3697170", VA = "0x183698B70")]
	private void UpdateUpperBodyLayerWeight()
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x3698F50", Offset = "0x3697550", VA = "0x183698F50")]
	private void HandleBlockRangedAttack()
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095A")]
	[Address(RVA = "0x3699150", Offset = "0x3697750", VA = "0x183699150")]
	public void resetLegInt()
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x3699250", Offset = "0x3697850", VA = "0x183699250")]
	public void OnSpineBlendOffTag(bool value)
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x3699270", Offset = "0x3697870", VA = "0x183699270")]
	public void UseHeadWallPusher(bool value)
	{
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x3699290", Offset = "0x3697890", VA = "0x183699290")]
	private void UpdateSpineBlendAnimVar()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095E")]
	[Address(RVA = "0x36993E0", Offset = "0x36979E0", VA = "0x1836993E0")]
	private void UpdateSpineBlendAnimVarThirdPerson()
	{
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095F")]
	[Address(RVA = "0x3699620", Offset = "0x3697C20", VA = "0x183699620")]
	public void SetSpineEnabled(bool value)
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000960")]
	[Address(RVA = "0x36996B0", Offset = "0x3697CB0", VA = "0x1836996B0")]
	public void SetSpineEnabledSmoothCoroutines(bool value)
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000961")]
	[Address(RVA = "0x3699750", Offset = "0x3697D50", VA = "0x183699750")]
	public void SetSpineEnabledSmooth(bool value)
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x6000962")]
	[Address(RVA = "0x3699770", Offset = "0x3697D70", VA = "0x183699770")]
	private Quaternion LookDirectionRot(float verticalAngle, Vector3 forward, Vector3 right)
	{
		return default(Quaternion);
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x36998F0", Offset = "0x3697EF0", VA = "0x1836998F0")]
	private void UpdateHeadLook(float normCamX)
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x369A100", Offset = "0x3698700", VA = "0x18369A100")]
	private void UpdateNeckAngle()
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x369A300", Offset = "0x3698900", VA = "0x18369A300")]
	private void HandleAimingAdjustments()
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x369A370", Offset = "0x3698970", VA = "0x18369A370")]
	private void updateCliffClimb()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x369C400", Offset = "0x369AA00", VA = "0x18369C400")]
	private void enableCliffReset()
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x369C410", Offset = "0x369AA10", VA = "0x18369C410")]
	private void enablePointAtMap()
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x369C460", Offset = "0x369AA60", VA = "0x18369C460")]
	private void lookAtCamera()
	{
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000A")]
	public event Action AnimatorMoveEvent
	{
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x369C490", Offset = "0x369AA90", VA = "0x18369C490")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x369C580", Offset = "0x369AB80", VA = "0x18369C580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x369C670", Offset = "0x369AC70", VA = "0x18369C670")]
	private void UpdateBodyColliders()
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x369CD40", Offset = "0x369B340", VA = "0x18369CD40")]
	private void UpdateClimbing()
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x369E3D0", Offset = "0x369C9D0", VA = "0x18369E3D0")]
	private IEnumerator fixExitClimbPosition(Vector3 groundPos)
	{
		return null;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x369E480", Offset = "0x369CA80", VA = "0x18369E480")]
	public void hitCombo()
	{
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000970")]
	[Address(RVA = "0x35FD780", Offset = "0x35FBD80", VA = "0x1835FD780")]
	private void resetCombo()
	{
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000971")]
	[Address(RVA = "0x369E540", Offset = "0x369CB40", VA = "0x18369E540")]
	internal void setComboOne()
	{
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x369E550", Offset = "0x369CB50", VA = "0x18369E550")]
	private void resetComboBlock()
	{
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000973")]
	[Address(RVA = "0x369E560", Offset = "0x369CB60", VA = "0x18369E560")]
	private void setStickAttack()
	{
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x369E5B0", Offset = "0x369CBB0", VA = "0x18369E5B0")]
	public void resetAnimator()
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000975")]
	[Address(RVA = "0x369E650", Offset = "0x369CC50", VA = "0x18369E650")]
	public void enableUseRootMotion()
	{
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x369E660", Offset = "0x369CC60", VA = "0x18369E660")]
	public void enterClimbMode()
	{
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000977")]
	[Address(RVA = "0x369E680", Offset = "0x369CC80", VA = "0x18369E680")]
	public void exitClimbMode()
	{
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000978")]
	[Address(RVA = "0x369EE70", Offset = "0x369D470", VA = "0x18369EE70")]
	public void resetPushSled()
	{
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x369EEE0", Offset = "0x369D4E0", VA = "0x18369EEE0")]
	public void sendEnableSledTrigger()
	{
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x369EF50", Offset = "0x369D550", VA = "0x18369EF50")]
	public void resetCliffClimb()
	{
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x369EFC0", Offset = "0x369D5C0", VA = "0x18369EFC0")]
	public void enableAnimLayer2()
	{
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void setDeathState()
	{
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x369F140", Offset = "0x369D740", VA = "0x18369F140")]
	internal void disableLockGravity()
	{
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097E")]
	[Address(RVA = "0x369F150", Offset = "0x369D750", VA = "0x18369F150")]
	internal void setBlockParams()
	{
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x369F2B0", Offset = "0x369D8B0", VA = "0x18369F2B0")]
	internal void checkCrouchLayers()
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x369F370", Offset = "0x369D970", VA = "0x18369F370")]
	public void forceAnimSpineReset()
	{
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000981")]
	[Address(RVA = "0x369F3E0", Offset = "0x369D9E0", VA = "0x18369F3E0")]
	public void resetCamera()
	{
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000982")]
	[Address(RVA = "0x369F4B0", Offset = "0x369DAB0", VA = "0x18369F4B0")]
	public void doSmoothEnableLayer2()
	{
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x369F560", Offset = "0x369DB60", VA = "0x18369F560")]
	public void doSmoothDisableLayer2()
	{
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x369F610", Offset = "0x369DC10", VA = "0x18369F610")]
	public IEnumerator smoothEnableLayer(int l, float s)
	{
		return null;
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x369F6C0", Offset = "0x369DCC0", VA = "0x18369F6C0")]
	public IEnumerator smoothDisableLayer(int l, float s)
	{
		return null;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x369F770", Offset = "0x369DD70", VA = "0x18369F770")]
	public IEnumerator smoothEnableLayerNew(int l)
	{
		return null;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x369F830", Offset = "0x369DE30", VA = "0x18369F830")]
	public IEnumerator smoothEnableLayerNew(int l, float speed)
	{
		return null;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x369F8E0", Offset = "0x369DEE0", VA = "0x18369F8E0")]
	public IEnumerator smoothDisableLayerNew(int l)
	{
		return null;
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x369F9A0", Offset = "0x369DFA0", VA = "0x18369F9A0")]
	public IEnumerator smoothDisableLayerNew(int l, float speed)
	{
		return null;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x369FA50", Offset = "0x369E050", VA = "0x18369FA50")]
	public void SetSmoothDisableLayer(int layer, bool isOn)
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x369FA60", Offset = "0x369E060", VA = "0x18369FA60")]
	public void stopSmoothEnableRoutines()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x369FB40", Offset = "0x369E140", VA = "0x18369FB40")]
	public void disconnectFromObject()
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x369FBD0", Offset = "0x369E1D0", VA = "0x18369FBD0")]
	public void cancelAnimatorActions()
	{
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x369FD20", Offset = "0x369E320", VA = "0x18369FD20")]
	public void AnimControlledPlayer(bool animControl, bool handleSpineLayer = true)
	{
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x369FEC0", Offset = "0x369E4C0", VA = "0x18369FEC0")]
	public void runReset2Scripts()
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void runWaitForInputScripts()
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x369FF40", Offset = "0x369E540", VA = "0x18369FF40")]
	private Transform findIntersectingPlayers()
	{
		return null;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x36A0280", Offset = "0x369E880", VA = "0x1836A0280")]
	public void LockPlayerAsDedicatedServer()
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x36A0E90", Offset = "0x369F490", VA = "0x1836A0E90")]
	public void lockPlayerParams()
	{
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x36A1D40", Offset = "0x36A0340", VA = "0x1836A1D40")]
	public void unlockPlayerParams()
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000995")]
	[Address(RVA = "0x36A2AE0", Offset = "0x36A10E0", VA = "0x1836A2AE0")]
	public void EnableMeleeWeaponController(bool enable)
	{
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x36A2AF0", Offset = "0x36A10F0", VA = "0x1836A2AF0")]
	public bool GetLookAtTree()
	{
		return default(bool);
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x36A2B00", Offset = "0x36A1100", VA = "0x1836A2B00")]
	public void SetLookAtTree(Vector3 corePos)
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x36A2B20", Offset = "0x36A1120", VA = "0x1836A2B20")]
	public void ClearLookAtTree()
	{
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x36A2B30", Offset = "0x36A1130", VA = "0x1836A2B30")]
	public Vector3 GetTreeCorePosition()
	{
		return default(Vector3);
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x36A2B50", Offset = "0x36A1150", VA = "0x1836A2B50")]
	public void AddMovement(Vector2 movement)
	{
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x36A2B90", Offset = "0x36A1190", VA = "0x1836A2B90")]
	public void RegisterInterruptedAction(Action interruptedAction)
	{
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x36A2C80", Offset = "0x36A1280", VA = "0x1836A2C80")]
	public void UnregisterInterruptedAction(Action interruptedAction)
	{
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x36A2D70", Offset = "0x36A1370", VA = "0x1836A2D70")]
	public void InterruptAction()
	{
	}

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000B")]
	private event Action OnActionInterrupted
	{
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x36A2B90", Offset = "0x36A1190", VA = "0x1836A2B90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x36A2C80", Offset = "0x36A1280", VA = "0x1836A2C80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x36A2D90", Offset = "0x36A1390", VA = "0x1836A2D90")]
	public void StandUpFromCrash(int sceneVar)
	{
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x36A2E40", Offset = "0x36A1440", VA = "0x1836A2E40")]
	private IEnumerator StandUpFromCrashRoutine(int sceneVar)
	{
		return null;
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x36A2F00", Offset = "0x36A1500", VA = "0x1836A2F00")]
	private void DestroyStandUpProps()
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x36A3000", Offset = "0x36A1600", VA = "0x1836A3000")]
	private void DestroyProp(GameObject propTarget)
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x36A30E0", Offset = "0x36A16E0", VA = "0x1836A30E0")]
	private void SpawnStandUpProps()
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x36A3180", Offset = "0x36A1780", VA = "0x1836A3180")]
	private void SetPropNetworkState(bool value)
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x36A32A0", Offset = "0x36A18A0", VA = "0x1836A32A0")]
	public void OnStandUpPropsChanged(int value)
	{
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x36A32C0", Offset = "0x36A18C0", VA = "0x1836A32C0")]
	public void OnStandupPropHide(int value)
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x36A32F0", Offset = "0x36A18F0", VA = "0x1836A32F0")]
	private void SetupSyncedProp(Animator playerAnimator, GameObject animProp, ref GameObject instance)
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x36A38B0", Offset = "0x36A1EB0", VA = "0x1836A38B0")]
	public void LockForHiddenCutscene(bool hideRemotePlayers = false)
	{
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x36A3960", Offset = "0x36A1F60", VA = "0x1836A3960")]
	public void UnlockFromHiddenCutscene()
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x36A3A10", Offset = "0x36A2010", VA = "0x1836A3A10")]
	public void LockForCutscene()
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x36A3B10", Offset = "0x36A2110", VA = "0x1836A3B10")]
	public void UnlockFromCutscene()
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x36A3D40", Offset = "0x36A2340", VA = "0x1836A3D40")]
	public void SetPlayerLocked(bool onOff)
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x36A3EF0", Offset = "0x36A24F0", VA = "0x1836A3EF0")]
	public void RegisterCutsceneDisconnectReceiver(ICutsceneDisconnectReceiver receiver)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x36A3FB0", Offset = "0x36A25B0", VA = "0x1836A3FB0")]
	public void UnregisterCutsceneDisconnectReceiver(ICutsceneDisconnectReceiver receiver)
	{
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x36A4030", Offset = "0x36A2630", VA = "0x1836A4030")]
	public void TriggerCutsceneDisconnect()
	{
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x36A4180", Offset = "0x36A2780", VA = "0x1836A4180")]
	private void ClearVelocityXZ()
	{
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x36A4350", Offset = "0x36A2950", VA = "0x1836A4350")]
	public void StartKnockdown(PlayerAnimatorControl.KnockdownType knockdownType)
	{
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x36A45D0", Offset = "0x36A2BD0", VA = "0x1836A45D0")]
	public bool IsMidKnockdown()
	{
		return default(bool);
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x36A45F0", Offset = "0x36A2BF0", VA = "0x1836A45F0")]
	private void UpdateKnockdownLocal()
	{
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x36A4750", Offset = "0x36A2D50", VA = "0x1836A4750")]
	private void ClearKnockdown()
	{
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x36A4890", Offset = "0x36A2E90", VA = "0x1836A4890")]
	public void RegisterKnockDownReceiver(IKnockDownReceiver knockDownReceiver)
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x36A4950", Offset = "0x36A2F50", VA = "0x1836A4950")]
	public void UnregisterKnockDownReceiver(IKnockDownReceiver knockDownReceiver)
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x36A49D0", Offset = "0x36A2FD0", VA = "0x1836A49D0")]
	private void SendKnockDownStarted()
	{
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00004848 File Offset: 0x00002A48
	// (set) Token: 0x060009BA RID: 2490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000128")]
	public bool IsSledding
	{
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x36A4B20", Offset = "0x36A3120", VA = "0x1836A4B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x36A4B30", Offset = "0x36A3130", VA = "0x1836A4B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060009BB RID: 2491 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x17000129")]
	public bool SledIsSlowingDown
	{
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x36A4B40", Offset = "0x36A3140", VA = "0x1836A4B40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x36A4B50", Offset = "0x36A3150", VA = "0x1836A4B50")]
	private void Update_Sledding()
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x36A4B70", Offset = "0x36A3170", VA = "0x1836A4B70")]
	private void LateUpdate_Sledding()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x36A4E50", Offset = "0x36A3450", VA = "0x1836A4E50")]
	private void FixedUpdate_Sledding()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x36A4F90", Offset = "0x36A3590", VA = "0x1836A4F90")]
	private IEnumerator FinalizeSledding()
	{
		return null;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x36A5020", Offset = "0x36A3620", VA = "0x1836A5020")]
	private void SleddingUpdate()
	{
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x36A5410", Offset = "0x36A3A10", VA = "0x1836A5410")]
	private void SleddingFixedUpdate()
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x36A6550", Offset = "0x36A4B50", VA = "0x1836A6550")]
	private void StartSledding()
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x36A68D0", Offset = "0x36A4ED0", VA = "0x1836A68D0")]
	private void EndSledding()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x36A6DC0", Offset = "0x36A53C0", VA = "0x1836A6DC0")]
	public void StopSledding()
	{
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x36A6DD0", Offset = "0x36A53D0", VA = "0x1836A6DD0")]
	private IEnumerator ScaleCapsuleForSledding(bool enable)
	{
		return null;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x36A6E20", Offset = "0x36A5420", VA = "0x1836A6E20")]
	public void SetSpineAimTwistFactor(float twist)
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x36A6E30", Offset = "0x36A5430", VA = "0x1836A6E30")]
	public void SetSplineBlendForItem(int itemId, bool enable, float weight = 1f)
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x36A6EF0", Offset = "0x36A54F0", VA = "0x1836A6EF0")]
	private void GetSpineAimTargetWeight(out float targetPitchAimWeight, out float targetHeadingAimWeight)
	{
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x36A71D0", Offset = "0x36A57D0", VA = "0x1836A71D0")]
	private void UpdateSpineAimControl(float pitchFactor, float headingFactor)
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x36A7B50", Offset = "0x36A6150", VA = "0x1836A7B50")]
	private void SnapToValueWithinThreshold(ref float value, float target, float threshold)
	{
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060009CB RID: 2507 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x1700012A")]
	public bool IsSwimming
	{
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x36A7B70", Offset = "0x36A6170", VA = "0x1836A7B70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060009CC RID: 2508 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x1700012B")]
	public bool IsUnderwater
	{
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x36A7B80", Offset = "0x36A6180", VA = "0x1836A7B80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060009CD RID: 2509 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x1700012C")]
	public bool InWater
	{
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x36A7B90", Offset = "0x36A6190", VA = "0x1836A7B90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060009CE RID: 2510 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x1700012D")]
	public bool WaterBlock
	{
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x36A7BA0", Offset = "0x36A61A0", VA = "0x1836A7BA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060009CF RID: 2511 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060009D0 RID: 2512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000C")]
	public event Action OnUnderWaterEvent
	{
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x36A7BB0", Offset = "0x36A61B0", VA = "0x1836A7BB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x36A7CA0", Offset = "0x36A62A0", VA = "0x1836A7CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060009D1 RID: 2513 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060009D2 RID: 2514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000D")]
	public event Action OnAboveWaterEvent
	{
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x36A7D90", Offset = "0x36A6390", VA = "0x1836A7D90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x36A7E80", Offset = "0x36A6480", VA = "0x1836A7E80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x36A7F70", Offset = "0x36A6570", VA = "0x1836A7F70")]
	private void SwimmingAwake()
	{
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x36A8170", Offset = "0x36A6770", VA = "0x1836A8170")]
	private void UpdateInWaterControl()
	{
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x36A8C40", Offset = "0x36A7240", VA = "0x1836A8C40")]
	private void SetIsSwimming(bool value)
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x36A8EA0", Offset = "0x36A74A0", VA = "0x1836A8EA0")]
	public void RegisterEnterSwimmingReceiver(IEnterSwimmingReceiver receiver)
	{
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x36A8FB0", Offset = "0x36A75B0", VA = "0x1836A8FB0")]
	private void DivingUnstashItems()
	{
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x36A90B0", Offset = "0x36A76B0", VA = "0x1836A90B0")]
	private void DivingStashItems()
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x36A91F0", Offset = "0x36A77F0", VA = "0x1836A91F0")]
	private void SwimmingStashItems()
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x36A9370", Offset = "0x36A7970", VA = "0x1836A9370")]
	private void SwimmingUnstashItems()
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x36A9540", Offset = "0x36A7B40", VA = "0x1836A9540")]
	private bool SwimmingShouldStashItem(ItemInstance item)
	{
		return default(bool);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x36A97F0", Offset = "0x36A7DF0", VA = "0x1836A97F0")]
	public void UpdateUnderSurface(float distance)
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x36A9D90", Offset = "0x36A8390", VA = "0x1836A9D90")]
	private void GetWaterLevel(out float height, out Vector3 normal, out Vector3 surfaceVel)
	{
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x36A9E90", Offset = "0x36A8490", VA = "0x1836A9E90")]
	private void DisableSwimming()
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x36AA390", Offset = "0x36A8990", VA = "0x1836AA390")]
	private void ClearSwimmingLayerController()
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x36AA490", Offset = "0x36A8A90", VA = "0x1836AA490")]
	private void UpdateSwimmingCameraAngleParams()
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x36AA540", Offset = "0x36A8B40", VA = "0x1836AA540")]
	private void ApplySwimmingLayerController()
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x36AA770", Offset = "0x36A8D70", VA = "0x1836AA770")]
	private void UpdateLighterInWaterControl()
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x36AAC70", Offset = "0x36A9270", VA = "0x1836AAC70")]
	public PlayerAnimatorControl()
	{
	}

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _isNetworkPlayer;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x24")]
	public float playerColliderRadius;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x28")]
	public float armMultiplyer;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody controller;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("setup")]
	private playerScriptSetup _playerScriptSetup;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("animEvents")]
	[SerializeField]
	private animEventsManager _animEventsManager;

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PlayerAAnimatorLayersController _layerController;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x50")]
	public Transform sledPivot;

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x58")]
	public CapsuleCollider playerCollider;

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x60")]
	public SphereCollider playerHeadCollider;

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CapsuleCollider _wallOffsetCollider;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _maxWallOffsetPush;

	// Token: 0x04000759 RID: 1881
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _wallOffsetColliderRadiusMultiplier;

	// Token: 0x0400075A RID: 1882
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float _wallOffsetColliderRaise;

	// Token: 0x0400075B RID: 1883
	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float _wallOffsetColliderLower;

	// Token: 0x0400075C RID: 1884
	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _wallOffsetSpineBendMultiplier;

	// Token: 0x0400075D RID: 1885
	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float _wallOffsetSpineBendAdd;

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float _wallOffsetGroundSmashMultiplier;

	// Token: 0x0400075F RID: 1887
	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x90")]
	public ForceLocalPosZero forcePos;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x98")]
	public wallTriggerSetup wallSetup;

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject cliffCollide;

	// Token: 0x04000762 RID: 1890
	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private PlayerSlideController _slideController;

	// Token: 0x04000763 RID: 1891
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("maxSpeed")]
	public float _maxInputSpeed;

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0xB4")]
	public float torsoFollowSpeed;

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0xB8")]
	public float _walkBlendSpeed;

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0xBC")]
	public float _overallBlendSpeed;

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0xC0")]
	public float storePrevYRotSpeed;

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0xC4")]
	public float offsetFlintlockArmsMult;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0xC8")]
	public float offsetFlintlockHandsMult;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private float _overallSpeed;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private bool _allowSpineIk;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0xD1")]
	public bool _headLookActive;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PlayerAnimatorControl.JointWeights _lookUpWeights;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayerAnimatorControl.JointWeights _lookDownWeights;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0xE8")]
	private float _headLookWeight;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0xEC")]
	public int combo;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0xF0")]
	public bool lockGravity;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0xF1")]
	public bool leftArmActive;

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0xF2")]
	public bool blockCamX;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0xF3")]
	public bool endGameCutScene;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0xF4")]
	public bool fullyAttachedToSled;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0xF5")]
	public bool useRootMotion;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0xF6")]
	public bool useRootRotation;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0xF7")]
	private bool _isConnectedToLogSled;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0xF8")]
	public bool onRope;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0xF9")]
	public bool onRopeHeightCheck;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0xFA")]
	private bool carry;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0xFB")]
	public bool injured;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0xFC")]
	public bool cliffClimb;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0xFD")]
	public bool allowCliffReset;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0xFE")]
	public bool doingFullBodyAction;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0xFF")]
	public bool sitting;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x100")]
	public bool standingOnRaft;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x101")]
	public bool blockInventoryOpen;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x102")]
	public bool enteringACave;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x104")]
	public float _normCamX;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x108")]
	public float _absCamX;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x10C")]
	public bool onRaft;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x10D")]
	public bool introCutScene;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x10E")]
	private bool _doingGroundChop;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x10F")]
	public bool coldOffsetBool;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x114")]
	public float clampArmsVal;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x118")]
	public float wristAimOffset;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x11C")]
	public bool fovAimMode;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x120")]
	public float leftArmDamp;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x124")]
	public bool onRopeWithGroundBelow;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x125")]
	public bool blockHeightCheck;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x128")]
	public float LIFT_FORCE_MULT;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x12C")]
	public float THRUST_FORCE_MULT;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x130")]
	public float OVERSHOOT_SLOWDOWN_MULT;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x134")]
	public float OVERSHOOT_MULT;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x138")]
	public float DOWNFORCE_MULT;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x13C")]
	public float MAX_GLIDER_VELOCITY;

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x140")]
	public float debugLift;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x144")]
	public float debugForwardThrust;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x148")]
	public float debugDownForce;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x14C")]
	public float debugForwardMag;

	// Token: 0x0400079B RID: 1947
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x150")]
	public float debugForwardDir;

	// Token: 0x0400079C RID: 1948
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x154")]
	private bool _meleeWeaponControllerEnabled;

	// Token: 0x0400079D RID: 1949
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x155")]
	private bool _settingFullBodyWeightFromTransition;

	// Token: 0x0400079E RID: 1950
	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x158")]
	private Animator _animator;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x160")]
	private Quaternion armAngle;

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x170")]
	private Vector3 camForward;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x17C")]
	private float camX;

	// Token: 0x040007A2 RID: 1954
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x180")]
	private float camYOffset;

	// Token: 0x040007A3 RID: 1955
	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x188")]
	private Transform closePlayer;

	// Token: 0x040007A4 RID: 1956
	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x190")]
	private int closePlayerCheck;

	// Token: 0x040007A5 RID: 1957
	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x194")]
	private float closePlayerHeight;

	// Token: 0x040007A6 RID: 1958
	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x198")]
	private float closePlayerYVel;

	// Token: 0x040007A7 RID: 1959
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x19C")]
	private float coldOffsetTimer;

	// Token: 0x040007A8 RID: 1960
	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x1A0")]
	private float colliderMove;

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x1A4")]
	private bool comboBlock;

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x1A8")]
	public AnimatorStateInfo _playerBaseState;

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x1CC")]
	public AnimatorStateInfo _playerUpperBodyState;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x1F0")]
	public bool _playerUpperBodyInTransition;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x1F4")]
	private AnimatorStateInfo currLayterState7;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x218")]
	private float currMag;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x21C")]
	private float curVel;

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x220")]
	private float curVelY;

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x224")]
	private bool doFootReset;

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x225")]
	private bool _doingJumpCrouch;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x228")]
	private int fixedCount;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x22C")]
	private float fovOverride;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x230")]
	private float frozenUpdateTimer;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x234")]
	public AnimatorStateInfo _playerFullBodyState;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x258")]
	public AnimatorStateInfo _playerLeftArmState;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x27C")]
	private Vector3 getPlayerPos;

	// Token: 0x040007B9 RID: 1977
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x288")]
	private readonly float headColliderZpos;

	// Token: 0x040007BA RID: 1978
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x28C")]
	private float _horizontalMovementSpeed;

	// Token: 0x040007BB RID: 1979
	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x290")]
	private float hVel;

	// Token: 0x040007BC RID: 1980
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x294")]
	private float initialAccel;

	// Token: 0x040007BD RID: 1981
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x298")]
	private Vector3 lastPlayerPos;

	// Token: 0x040007BE RID: 1982
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x2A4")]
	private float lastYPos;

	// Token: 0x040007BF RID: 1983
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x2A8")]
	private AnimatorStateInfo locoState;

	// Token: 0x040007C0 RID: 1984
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x2CC")]
	private float lookDownBlendVal;

	// Token: 0x040007C1 RID: 1985
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x2D0")]
	private weaponInfo mainWeaponInfo;

	// Token: 0x040007C2 RID: 1986
	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x2D8")]
	private float maxHeadColliderOffset;

	// Token: 0x040007C3 RID: 1987
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x2DC")]
	private Vector3 _modLocalVelVR;

	// Token: 0x040007C4 RID: 1988
	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x2E8")]
	private float mouseCurrentPosx;

	// Token: 0x040007C5 RID: 1989
	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x2EC")]
	private float mouseDeltax;

	// Token: 0x040007C6 RID: 1990
	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x2F0")]
	public AnimatorStateInfo _playerNextFullBodyState;

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x314")]
	public AnimatorStateInfo _playerNextLeftArmState;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x338")]
	public AnimatorStateInfo _playerNextBaseState;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x35C")]
	public AnimatorStateInfo _playerNextUpperBodyState;

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x380")]
	private RaycastHit nHit;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x3AC")]
	private Vector3 normal1;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x3B8")]
	private Vector3 normal2;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x3C4")]
	private Vector3 normal3;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x3D0")]
	private Vector3 normal4;

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x3DC")]
	private Vector3 normal5;

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x3E8")]
	private PlayerInventory player;

	// Token: 0x040007D1 RID: 2001
	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x3F0")]
	private float _prevCamY;

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x3F4")]
	private float prevMag;

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x3F8")]
	private Vector3 prevNormal;

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x408")]
	private Rigidbody rb;

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x410")]
	private playerHitReactions reactions;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x418")]
	private Transform rootTr;

	// Token: 0x040007D7 RID: 2007
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x420")]
	private int ropeFixDelay;

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x424")]
	private RaycastHit ropeHit;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x450")]
	private bool shouldUnlockLeftHandSlot;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x454")]
	private float smoothCamX;

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x458")]
	private float _smoothCamY;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x45C")]
	private float smoothForwarDir;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x460")]
	private float startPlaneBlend;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x464")]
	private float storeActualFovValue;

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x468")]
	private Quaternion storeLeftArmAngle;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x478")]
	private Vector3 tempPrevPos;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x484")]
	private Vector3 tempVelocity;

	// Token: 0x040007E2 RID: 2018
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x490")]
	private float torchCrouchOffset;

	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x498")]
	private Transform _transform;

	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x4A0")]
	private float _verticalMovementSpeed;

	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x4A4")]
	private float vVel;

	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x4A8")]
	private float waterBlendFloat;

	// Token: 0x040007E7 RID: 2023
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x4AC")]
	private float yVel;

	// Token: 0x040007E8 RID: 2024
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x4B0")]
	private bool _lookAtTree;

	// Token: 0x040007E9 RID: 2025
	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0x4B4")]
	private Vector3 _treeCorePos;

	// Token: 0x040007EA RID: 2026
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x4C0")]
	private readonly ILayerBehaviourActivator[] _spineLayerActivator;

	// Token: 0x040007EB RID: 2027
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x4C8")]
	private float _spineBlendLerpSpeed;

	// Token: 0x040007EC RID: 2028
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x4CC")]
	private bool _spineBendEnabled;

	// Token: 0x040007ED RID: 2029
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x4D0")]
	private int _spineBlendAnimVarDisabled;

	// Token: 0x040007EE RID: 2030
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x4D4")]
	private int _useHeadWallPusher;

	// Token: 0x040007EF RID: 2031
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x4D8")]
	private bool _disableAutoUpperBodyLayer;

	// Token: 0x040007F0 RID: 2032
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x4E0")]
	private Coroutine _smoothResetCameraYPositionRoutine;

	// Token: 0x040007F1 RID: 2033
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x4E8")]
	private readonly ILayerBehaviourActivator[] _deathLayerBehaviourActivators;

	// Token: 0x040007F2 RID: 2034
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x4F0")]
	private bool _cachedDeathState;

	// Token: 0x040007F4 RID: 2036
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x500")]
	private bool smoothDisableFullBodyLayer;

	// Token: 0x040007F5 RID: 2037
	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x504")]
	private Vector2 _lastInputMovement;

	// Token: 0x040007F6 RID: 2038
	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x50C")]
	private Vector2 _currentInputMovement;

	// Token: 0x040007F7 RID: 2039
	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x518")]
	private AnimatorLayersController _layersController;

	// Token: 0x040007F8 RID: 2040
	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x520")]
	private bool _hasTriggeredSlide;

	// Token: 0x040007F9 RID: 2041
	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x524")]
	private float _terrainSlideAngle;

	// Token: 0x040007FA RID: 2042
	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x528")]
	private bool _slidingDown;

	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x529")]
	private bool _hasAlignedToGround;

	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x52A")]
	private bool _doingCrouch;

	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x538")]
	[SerializeField]
	private GameObject _standUpInventoryWrapProp;

	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x540")]
	[SerializeField]
	[FormerlySerializedAs("_standUpEmergencyPack")]
	private GameObject _standUpEmergencyPackProp;

	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x548")]
	[SerializeField]
	private FovManager.FieldOfViewChangeSettings _standUpFromCrashFovChangeSettings;

	// Token: 0x04000801 RID: 2049
	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x550")]
	private GameObject _standUpInventoryWrapPropInstance;

	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x558")]
	private GameObject _standUpEmergencyPackPropInstance;

	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x560")]
	private readonly List<ICutsceneDisconnectReceiver> _cutsceneDisconnectReceivers;

	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x568")]
	private float _knockdownTime;

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x570")]
	private readonly ILayerBehaviourActivator[] _knockDownLayerBehaviourActivators;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x578")]
	private readonly List<IKnockDownReceiver> _knockDownReceivers;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x580")]
	private PlayerAnimatorControl.KnockdownType _knockdownType;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x584")]
	private float _currentSledVelocity;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x588")]
	private float _sleddingBlendVal;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x58C")]
	private float _sleddingStopTimer;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x590")]
	private float _sledHorizontalVelocity;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x594")]
	private float _smoothSleddingBlend;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x598")]
	private Vector2 _originalCameraRotationRange;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x5A0")]
	private bool _forceStopSledding;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x5A4")]
	[SerializeField]
	private float _spine1PitchOffsetAmount;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x5A8")]
	[SerializeField]
	private float _spine2PitchOffsetAmount;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x5AC")]
	[SerializeField]
	private float _spine3PitchOffsetAmount;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x5B0")]
	[SerializeField]
	private float _spine1HeadingOffsetAmount;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x5B4")]
	[SerializeField]
	private float _spine2HeadingOffsetAmount;

	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x5B8")]
	[SerializeField]
	private float _spine3HeadingOffsetAmount;

	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x5BC")]
	private float _spinePitchAimWeight;

	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x5C0")]
	private float _spineHeadingAimWeight;

	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x5C4")]
	private float _spineAimTwistFactor;

	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x5C8")]
	private Dictionary<int, float> _spineBlendWeightsForItems;

	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	private const string SwimDiveBoolKey = "swimDiveBool";

	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	private const string SwimmingBoolKey = "swimmingBool";

	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x5D0")]
	[SerializeField]
	private GameObject _underWaterGroup;

	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x5D8")]
	[SerializeField]
	private GameObject _aboveWaterGroup;

	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x5E0")]
	[FormerlySerializedAs("swimLayerChange")]
	[SerializeField]
	private bool _swimLayerChange;

	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x5E1")]
	[SerializeField]
	[FormerlySerializedAs("swimming")]
	private bool _isSwimming;

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x5E8")]
	[SerializeField]
	private List<WaterLevelReceiverMono> _waterLevelReceivers;

	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x5F0")]
	[SerializeField]
	private float _underWaterOffset;

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x5F4")]
	[SerializeField]
	private Vector2 _waterMinHeightRange;

	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x600")]
	[ItemIdPicker(Types.Equippable, true)]
	[SerializeField]
	private List<int> _swimmingBlockStashItems;

	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x608")]
	private Vector3 _rootPosition;

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x614")]
	private float _disableSwimmingTimer;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x618")]
	private float _waterLevelCache;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x61C")]
	private Vector3 _waterNormalCache;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x628")]
	private Vector3 _waterSurfaceVelocityCache;

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x634")]
	private bool _divingStashedLeft;

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x635")]
	private bool _divingStashedRight;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x636")]
	private bool _divingStarted;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x637")]
	private bool _swimmingStashedLeft;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x638")]
	private bool _swimmingStashedRight;

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x639")]
	private bool waterBlock;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x63A")]
	private bool _isUnderwater;

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x63B")]
	private bool _isSwimmingUnderwater;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x63C")]
	private bool _wasInWater;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x63D")]
	private bool _appliedSwimmingLayerController;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x640")]
	private LayerBehaviourActivator _fullBodySwimmingLayerBehaviourActivator;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x648")]
	private readonly List<IEnterSwimmingReceiver> _enterSwimmingReceivers;

	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	[Serializable]
	private class JointWeights
	{
		// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x36ABD50", Offset = "0x36AA350", VA = "0x1836ABD50")]
		public JointWeights()
		{
		}

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x10")]
		public float _neck0Weight;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x14")]
		public float _neck1Weight;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x18")]
		public float _head0Weight;
	}

	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public enum KnockdownType
	{
		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		HitKnockdown,
		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		Crash
	}
}
