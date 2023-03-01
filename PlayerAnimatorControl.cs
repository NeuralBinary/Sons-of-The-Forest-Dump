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

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
[DefaultExecutionOrder(200)]
[AddComponentMenu("TheForest/Player Animator Control")]
public class PlayerAnimatorControl : MonoBehaviour
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x17000119")]
	public bool DoingGroundChop
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2E1DF30", Offset = "0x2E1CF30", VA = "0x182E1DF30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x060008DA RID: 2266 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x1700011A")]
	public bool HorizontalMovement
	{
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x2F39900", Offset = "0x2F38900", VA = "0x182F39900")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060008DB RID: 2267 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x1700011B")]
	public bool VerticalMovement
	{
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2F39980", Offset = "0x2F38980", VA = "0x182F39980")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x060008DC RID: 2268 RVA: 0x00004440 File Offset: 0x00002640
	[Token(Token = "0x1700011C")]
	public bool IsMeleeWeaponControllerEnabled
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2F39930", Offset = "0x2F38930", VA = "0x182F39930")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060008DD RID: 2269 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x1700011D")]
	public float CurrentMovementSpeed
	{
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2397C70", Offset = "0x2396C70", VA = "0x182397C70")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x060008DE RID: 2270 RVA: 0x00004470 File Offset: 0x00002670
	[Token(Token = "0x1700011E")]
	public bool DisableAutoUpperBodyLayer
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x2F398F0", Offset = "0x2F388F0", VA = "0x182F398F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x2F2E610", Offset = "0x2F2D610", VA = "0x182F2E610")]
	public bool SetDisableAutoUpperBodyLayer(bool value)
	{
		return default(bool);
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x2F2A5F0", Offset = "0x2F295F0", VA = "0x182F2A5F0")]
	private void Awake()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x2F30570", Offset = "0x2F2F570", VA = "0x182F30570")]
	private void Start()
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x2F2DDD0", Offset = "0x2F2CDD0", VA = "0x182F2DDD0")]
	private void OnEnable()
	{
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x2F2DCB0", Offset = "0x2F2CCB0", VA = "0x182F2DCB0")]
	private void OnDisable()
	{
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x2F2E070", Offset = "0x2F2D070", VA = "0x182F2E070")]
	private void OnStopSlide()
	{
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x2F2E050", Offset = "0x2F2D050", VA = "0x182F2E050")]
	private void OnStartSlide()
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x2F372E0", Offset = "0x2F362E0", VA = "0x182F372E0")]
	private void Update()
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x2F38410", Offset = "0x2F37410", VA = "0x182F38410")]
	private static bool WasGrounded()
	{
		return default(bool);
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x2F35650", Offset = "0x2F34650", VA = "0x182F35650")]
	public void UpdatePlayerVelocity(Vector2 movementInput)
	{
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x2F2B800", Offset = "0x2F2A800", VA = "0x182F2B800")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x2F2D110", Offset = "0x2F2C110", VA = "0x182F2D110")]
	public bool IsMidSlideDown()
	{
		return default(bool);
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x2F2D080", Offset = "0x2F2C080", VA = "0x182F2D080")]
	public bool IsMidHitReact()
	{
		return default(bool);
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x2F2D350", Offset = "0x2F2C350", VA = "0x182F2D350")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x2F2CD90", Offset = "0x2F2BD90", VA = "0x182F2CD90")]
	private bool HasClampedSpine()
	{
		return default(bool);
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x2F370C0", Offset = "0x2F360C0", VA = "0x182F370C0")]
	private void UpdateWallPusherOffset()
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x2F2ECB0", Offset = "0x2F2DCB0", VA = "0x182F2ECB0")]
	public void SetWallOffset(float distance)
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x2F2DC20", Offset = "0x2F2CC20", VA = "0x182F2DC20")]
	private void OnDestroy()
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x2F2DAF0", Offset = "0x2F2CAF0", VA = "0x182F2DAF0")]
	private void OnAnimatorMove()
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x2F2E090", Offset = "0x2F2D090", VA = "0x182F2E090")]
	private void OnValidate()
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x2F33580", Offset = "0x2F32580", VA = "0x182F33580")]
	private void UpdateComponents()
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	private void UpdateComponentInParent<T>(ref T target, Component targetComponent) where T : Component
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F5")]
	private void UpdateComponent<T>(ref T target, Component targetComponent) where T : Component
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F6")]
	private void UpdateComponent<T>(ref T target, GameObject targetGameObject) where T : Component
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x2F2E310", Offset = "0x2F2D310", VA = "0x182F2E310")]
	public void RegisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x2F30EC0", Offset = "0x2F2FEC0", VA = "0x182F30EC0")]
	public void UnregisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x2F2E3A0", Offset = "0x2F2D3A0", VA = "0x182F2E3A0")]
	public void RegisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
	{
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x2F30F50", Offset = "0x2F2FF50", VA = "0x182F30F50")]
	public void UnregisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
	{
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00004500 File Offset: 0x00002700
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x2F2CE50", Offset = "0x2F2BE50", VA = "0x182F2CE50")]
	public bool HasLayerActivator(int layer)
	{
		return default(bool);
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x2F2BBC0", Offset = "0x2F2ABC0", VA = "0x182F2BBC0")]
	public string GetLayerActivatorLog()
	{
		return null;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x2F2D050", Offset = "0x2F2C050", VA = "0x182F2D050")]
	private bool IsLeftHandBusy()
	{
		return default(bool);
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x2F2D120", Offset = "0x2F2C120", VA = "0x182F2D120")]
	private bool IsThirdPerson()
	{
		return default(bool);
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x2F2FF50", Offset = "0x2F2EF50", VA = "0x182F2FF50")]
	public void SmoothResetCameraYPosition()
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x2F2FF00", Offset = "0x2F2EF00", VA = "0x182F2FF00")]
	private static IEnumerator SmoothResetCameraYPositionRoutine()
	{
		return null;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x2F31E20", Offset = "0x2F30E20", VA = "0x182F31E20")]
	private void UpdateCameraAngleParams(float normCamXOld)
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x2F35770", Offset = "0x2F34770", VA = "0x182F35770")]
	private void UpdatePlayerVelocity(float oldHSpeed, float oldVSpeed, float oldOSpeed, Vector2 movementInput)
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x2F2A820", Offset = "0x2F29820", VA = "0x182F2A820")]
	private Vector3 CalculateBaseLocalVelocity(Vector2 input)
	{
		return default(Vector3);
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x2F2BC70", Offset = "0x2F2AC70", VA = "0x182F2BC70")]
	private static Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x2F2AA20", Offset = "0x2F29A20", VA = "0x182F2AA20")]
	private void ClearFullBodyWeightFromTransition()
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x2F30FE0", Offset = "0x2F2FFE0", VA = "0x182F30FE0")]
	private void UpdateAnimLayerWeights()
	{
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x2F2DB70", Offset = "0x2F2CB70", VA = "0x182F2DB70")]
	public void OnDeath()
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x2F2CFE0", Offset = "0x2F2BFE0", VA = "0x182F2CFE0")]
	public bool IsInDeathState()
	{
		return default(bool);
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x2F2A970", Offset = "0x2F29970", VA = "0x182F2A970")]
	private bool CheckDeathState()
	{
		return default(bool);
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x2F33720", Offset = "0x2F32720", VA = "0x182F33720")]
	private void UpdateDeathState()
	{
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x2F2CF10", Offset = "0x2F2BF10", VA = "0x182F2CF10")]
	private bool IsForceUpperBodyTag(int tagHash)
	{
		return default(bool);
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x2F36D90", Offset = "0x2F35D90", VA = "0x182F36D90")]
	private void UpdateUpperBodyLayerWeight()
	{
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x2F2C190", Offset = "0x2F2B190", VA = "0x182F2C190")]
	private void HandleBlockRangedAttack()
	{
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x2F35BB0", Offset = "0x2F34BB0", VA = "0x182F35BB0")]
	private void UpdateSledPushControl()
	{
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x2F3A710", Offset = "0x2F39710", VA = "0x182F3A710")]
	public void resetLegInt()
	{
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x2F2DEF0", Offset = "0x2F2CEF0", VA = "0x182F2DEF0")]
	public void OnSpineBlendOffTag(bool value)
	{
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x2F383F0", Offset = "0x2F373F0", VA = "0x182F383F0")]
	public void UseHeadWallPusher(bool value)
	{
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x2F365A0", Offset = "0x2F355A0", VA = "0x182F365A0")]
	private void UpdateSpineBlendAnimVar()
	{
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x2F36420", Offset = "0x2F35420", VA = "0x182F36420")]
	private void UpdateSpineBlendAnimVarThirdPerson()
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x2F2EBE0", Offset = "0x2F2DBE0", VA = "0x182F2EBE0")]
	public void SetSpineEnabled(bool value)
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x2F2EB20", Offset = "0x2F2DB20", VA = "0x182F2EB20")]
	public void SetSpineEnabledSmoothCoroutines(bool value)
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x2F2EBC0", Offset = "0x2F2DBC0", VA = "0x182F2EBC0")]
	public void SetSpineEnabledSmooth(bool value)
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000917")]
	[Address(RVA = "0x2F2EC10", Offset = "0x2F2DC10", VA = "0x182F2EC10")]
	public void SetSplineBlendForItem(int itemId, bool enable, float weight = 1f)
	{
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x6000918")]
	[Address(RVA = "0x2F2BD40", Offset = "0x2F2AD40", VA = "0x182F2BD40")]
	private float GetSpineAimTargetWeight()
	{
		return default(float);
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000919")]
	[Address(RVA = "0x2F35DF0", Offset = "0x2F34DF0", VA = "0x182F35DF0")]
	private void UpdateSpineAimControl(float normCamX)
	{
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x600091A")]
	[Address(RVA = "0x2F2DA00", Offset = "0x2F2CA00", VA = "0x182F2DA00")]
	private Quaternion LookDirectionRot(float verticalAngle, Vector3 forward, Vector3 right)
	{
		return default(Quaternion);
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091B")]
	[Address(RVA = "0x2F33F90", Offset = "0x2F32F90", VA = "0x182F33F90")]
	private void UpdateHeadLook(float normCamX)
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x2F353E0", Offset = "0x2F343E0", VA = "0x182F353E0")]
	private void UpdateNeckAngle()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x2F2C0E0", Offset = "0x2F2B0E0", VA = "0x182F2C0E0")]
	private void HandleAimingAdjustments()
	{
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x2F3B890", Offset = "0x2F3A890", VA = "0x182F3B890")]
	private void updateCliffClimb()
	{
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091F")]
	[Address(RVA = "0x2F39010", Offset = "0x2F38010", VA = "0x182F39010")]
	private void enableCliffReset()
	{
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000920")]
	[Address(RVA = "0x2F39020", Offset = "0x2F38020", VA = "0x182F39020")]
	private void enablePointAtMap()
	{
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000921")]
	[Address(RVA = "0x2F3A3C0", Offset = "0x2F393C0", VA = "0x182F3A3C0")]
	private void lookAtCamera()
	{
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000923 RID: 2339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000007")]
	public event Action AnimatorMoveEvent
	{
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2F38A60", Offset = "0x2F37A60", VA = "0x182F38A60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2F3A3F0", Offset = "0x2F393F0", VA = "0x182F3A3F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000924")]
	[Address(RVA = "0x2F31A30", Offset = "0x2F30A30", VA = "0x182F31A30")]
	private void UpdateBodyColliders()
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000925")]
	[Address(RVA = "0x2F32620", Offset = "0x2F31620", VA = "0x182F32620")]
	private void UpdateClimbing()
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000926")]
	[Address(RVA = "0x2F39840", Offset = "0x2F38840", VA = "0x182F39840")]
	private IEnumerator fixExitClimbPosition(Vector3 groundPos)
	{
		return null;
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x2F399B0", Offset = "0x2F389B0", VA = "0x182F399B0")]
	public void hitCombo()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x2ED47E0", Offset = "0x2ED37E0", VA = "0x182ED47E0")]
	private void resetCombo()
	{
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x2F3A9D0", Offset = "0x2F399D0", VA = "0x182F3A9D0")]
	internal void setComboOne()
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x2F3A700", Offset = "0x2F39700", VA = "0x182F3A700")]
	private void resetComboBlock()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x2F3A9E0", Offset = "0x2F399E0", VA = "0x182F3A9E0")]
	private void setStickAttack()
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x2F3A5D0", Offset = "0x2F395D0", VA = "0x182F3A5D0")]
	public void resetAnimator()
	{
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x2F39070", Offset = "0x2F38070", VA = "0x182F39070")]
	public void enableUseRootMotion()
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x2F39080", Offset = "0x2F38080", VA = "0x182F39080")]
	public void enterClimbMode()
	{
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x2F390A0", Offset = "0x2F380A0", VA = "0x182F390A0")]
	public void enterPushMode()
	{
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x2F39570", Offset = "0x2F38570", VA = "0x182F39570")]
	public void exitPushMode()
	{
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x2F390B0", Offset = "0x2F380B0", VA = "0x182F390B0")]
	public void exitClimbMode()
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x2F3A7D0", Offset = "0x2F397D0", VA = "0x182F3A7D0")]
	public void resetPushSled()
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x2F3A8B0", Offset = "0x2F398B0", VA = "0x182F3A8B0")]
	public void sendEnableSledTrigger()
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x2F3A6A0", Offset = "0x2F396A0", VA = "0x182F3A6A0")]
	public void resetCliffClimb()
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x2F38F50", Offset = "0x2F37F50", VA = "0x182F38F50")]
	public void enableAnimLayer2()
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void setDeathState()
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x2F38DB0", Offset = "0x2F37DB0", VA = "0x182F38DB0")]
	internal void disableLockGravity()
	{
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x2F3A910", Offset = "0x2F39910", VA = "0x182F3A910")]
	internal void setBlockParams()
	{
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x2F38D30", Offset = "0x2F37D30", VA = "0x182F38D30")]
	internal void checkCrouchLayers()
	{
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x2F398D0", Offset = "0x2F388D0", VA = "0x182F398D0")]
	public void forceAnimSpineReset()
	{
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x2F3A610", Offset = "0x2F39610", VA = "0x182F3A610")]
	public void resetCamera()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x2F38ED0", Offset = "0x2F37ED0", VA = "0x182F38ED0")]
	public void doSmoothEnableLayer2()
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x2F38E50", Offset = "0x2F37E50", VA = "0x182F38E50")]
	public void doSmoothDisableLayer2()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x2F3ACF0", Offset = "0x2F39CF0", VA = "0x182F3ACF0")]
	public IEnumerator smoothEnableLayer(int l, float s)
	{
		return null;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093F")]
	[Address(RVA = "0x2F3AB50", Offset = "0x2F39B50", VA = "0x182F3AB50")]
	public IEnumerator smoothDisableLayer(int l, float s)
	{
		return null;
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x2F3AC70", Offset = "0x2F39C70", VA = "0x182F3AC70")]
	public IEnumerator smoothEnableLayerNew(int l)
	{
		return null;
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x2F3ABE0", Offset = "0x2F39BE0", VA = "0x182F3ABE0")]
	public IEnumerator smoothEnableLayerNew(int l, float speed)
	{
		return null;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x2F3AAD0", Offset = "0x2F39AD0", VA = "0x182F3AAD0")]
	public IEnumerator smoothDisableLayerNew(int l)
	{
		return null;
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x2F3AA40", Offset = "0x2F39A40", VA = "0x182F3AA40")]
	public IEnumerator smoothDisableLayerNew(int l, float speed)
	{
		return null;
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x2F2EB10", Offset = "0x2F2DB10", VA = "0x182F2EB10")]
	public void SetSmoothDisableLayer(int layer, bool isOn)
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x2F3AD80", Offset = "0x2F39D80", VA = "0x182F3AD80")]
	public void stopSmoothEnableRoutines()
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x2F38DC0", Offset = "0x2F37DC0", VA = "0x182F38DC0")]
	public void disconnectFromObject()
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x2F38C40", Offset = "0x2F37C40", VA = "0x182F38C40")]
	public void cancelAnimatorActions()
	{
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x2F29FC0", Offset = "0x2F28FC0", VA = "0x182F29FC0")]
	public void AnimControlledPlayer(bool animControl, bool handleSpineLayer = true)
	{
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000949")]
	[Address(RVA = "0x2F3A830", Offset = "0x2F39830", VA = "0x182F3A830")]
	public void runReset2Scripts()
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void runWaitForInputScripts()
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x2F39580", Offset = "0x2F38580", VA = "0x182F39580")]
	private Transform findIntersectingPlayers()
	{
		return null;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x2F39A50", Offset = "0x2F38A50", VA = "0x182F39A50")]
	public void lockPlayerParams()
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x2F3ADE0", Offset = "0x2F39DE0", VA = "0x182F3ADE0")]
	public void unlockPlayerParams()
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void HandleGliderControlUpdate()
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x2F2C3A0", Offset = "0x2F2B3A0", VA = "0x182F2C3A0")]
	private void HandleGliderControl()
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x2F2B270", Offset = "0x2F2A270", VA = "0x182F2B270")]
	public void EnableMeleeWeaponController(bool enable)
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x2F2BC60", Offset = "0x2F2AC60", VA = "0x182F2BC60")]
	public bool GetLookAtTree()
	{
		return default(bool);
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x2F2E830", Offset = "0x2F2D830", VA = "0x182F2E830")]
	public void SetLookAtTree(Vector3 corePos)
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x2F2AB90", Offset = "0x2F29B90", VA = "0x182F2AB90")]
	public void ClearLookAtTree()
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x2F2BFC0", Offset = "0x2F2AFC0", VA = "0x182F2BFC0")]
	public Vector3 GetTreeCorePosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x2F29F80", Offset = "0x2F28F80", VA = "0x182F29F80")]
	public void AddMovement(Vector2 movement)
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x2F2E190", Offset = "0x2F2D190", VA = "0x182F2E190")]
	public void RegisterInterruptedAction(Action interruptedAction)
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x2F30E20", Offset = "0x2F2FE20", VA = "0x182F30E20")]
	public void UnregisterInterruptedAction(Action interruptedAction)
	{
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x2F2CEF0", Offset = "0x2F2BEF0", VA = "0x182F2CEF0")]
	public void InterruptAction()
	{
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000008")]
	private event Action OnActionInterrupted
	{
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2F2E190", Offset = "0x2F2D190", VA = "0x182F2E190")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x2F30E20", Offset = "0x2F2FE20", VA = "0x182F30E20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x2F30140", Offset = "0x2F2F140", VA = "0x182F30140")]
	public void StandUpFromCrash(int sceneVar)
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x2F300C0", Offset = "0x2F2F0C0", VA = "0x182F300C0")]
	private IEnumerator StandUpFromCrashRoutine(int sceneVar)
	{
		return null;
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x2F2ACC0", Offset = "0x2F29CC0", VA = "0x182F2ACC0")]
	private void DestroyStandUpProps()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095E")]
	[Address(RVA = "0x2F2AC40", Offset = "0x2F29C40", VA = "0x182F2AC40")]
	private void DestroyProp(GameObject propTarget)
	{
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095F")]
	[Address(RVA = "0x2F30020", Offset = "0x2F2F020", VA = "0x182F30020")]
	private void SpawnStandUpProps()
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000960")]
	[Address(RVA = "0x2F2E980", Offset = "0x2F2D980", VA = "0x182F2E980")]
	private void SetPropNetworkState(bool value)
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000961")]
	[Address(RVA = "0x2F2DF10", Offset = "0x2F2CF10", VA = "0x182F2DF10")]
	public void OnStandUpPropsChanged(int value)
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000962")]
	[Address(RVA = "0x2F2E020", Offset = "0x2F2D020", VA = "0x182F2E020")]
	public void OnStandupPropHide(int value)
	{
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x2F2EE80", Offset = "0x2F2DE80", VA = "0x182F2EE80")]
	private void SetupSyncedProp(Animator playerAnimator, GameObject animProp, ref GameObject instance)
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x2F2D8B0", Offset = "0x2F2C8B0", VA = "0x182F2D8B0")]
	public void LockForHiddenCutscene(bool hideRemotePlayers = false)
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x2F30C20", Offset = "0x2F2FC20", VA = "0x182F30C20")]
	public void UnlockFromHiddenCutscene()
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x2F2D7F0", Offset = "0x2F2C7F0", VA = "0x182F2D7F0")]
	public void LockForCutscene()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x2F30AA0", Offset = "0x2F2FAA0", VA = "0x182F30AA0")]
	public void UnlockFromCutscene()
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x2F2E850", Offset = "0x2F2D850", VA = "0x182F2E850")]
	public void SetPlayerLocked(bool onOff)
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x2F301D0", Offset = "0x2F2F1D0", VA = "0x182F301D0")]
	public void StartKnockdown()
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x2F2D0F0", Offset = "0x2F2C0F0", VA = "0x182F2D0F0")]
	public bool IsMidKnockdown()
	{
		return default(bool);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x2F34F90", Offset = "0x2F33F90", VA = "0x182F34F90")]
	private void UpdateKnockdown()
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x2F2AAE0", Offset = "0x2F29AE0", VA = "0x182F2AAE0")]
	private void ClearKnockdown()
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x2F2E230", Offset = "0x2F2D230", VA = "0x182F2E230")]
	public void RegisterKnockDownReceiver(IKnockDownReceiver knockDownReceiver)
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x2F2E4A0", Offset = "0x2F2D4A0", VA = "0x182F2E4A0")]
	private void SendKnockDownStarted()
	{
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x00004638 File Offset: 0x00002838
	// (set) Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011F")]
	public bool IsSledding
	{
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x2F39940", Offset = "0x2F38940", VA = "0x182F39940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2F3AA30", Offset = "0x2F39A30", VA = "0x182F3AA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x17000120")]
	public bool SledIsSlowingDown
	{
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2F39970", Offset = "0x2F38970", VA = "0x182F39970")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x2F372C0", Offset = "0x2F362C0", VA = "0x182F372C0")]
	private void Update_Sledding()
	{
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000973")]
	[Address(RVA = "0x2F2D130", Offset = "0x2F2C130", VA = "0x182F2D130")]
	private void LateUpdate_Sledding()
	{
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x2F2B6C0", Offset = "0x2F2A6C0", VA = "0x182F2B6C0")]
	private void FixedUpdate_Sledding()
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000975")]
	[Address(RVA = "0x2F2B650", Offset = "0x2F2A650", VA = "0x182F2B650")]
	private IEnumerator FinalizeSledding()
	{
		return null;
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x2F2FC20", Offset = "0x2F2EC20", VA = "0x182F2FC20")]
	private void SleddingUpdate()
	{
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000977")]
	[Address(RVA = "0x2F2F150", Offset = "0x2F2E150", VA = "0x182F2F150")]
	private void SleddingFixedUpdate()
	{
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000978")]
	[Address(RVA = "0x2F302D0", Offset = "0x2F2F2D0", VA = "0x182F302D0")]
	private void StartSledding()
	{
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x2F2B280", Offset = "0x2F2A280", VA = "0x182F2B280")]
	private void EndSledding()
	{
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x2F305C0", Offset = "0x2F2F5C0", VA = "0x182F305C0")]
	public void StopSledding()
	{
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x2F2E430", Offset = "0x2F2D430", VA = "0x182F2E430")]
	private IEnumerator ScaleCapsuleForSledding(bool enable)
	{
		return null;
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600097C RID: 2428 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x17000121")]
	public bool IsSwimming
	{
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2F39950", Offset = "0x2F38950", VA = "0x182F39950")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600097D RID: 2429 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x17000122")]
	public bool IsUnderwater
	{
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2F39960", Offset = "0x2F38960", VA = "0x182F39960")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600097E RID: 2430 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x17000123")]
	public bool InWater
	{
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2F39920", Offset = "0x2F38920", VA = "0x182F39920")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x17000124")]
	public bool WaterBlock
	{
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2F399A0", Offset = "0x2F389A0", VA = "0x182F399A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000009")]
	public event Action OnUnderWaterEvent
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2F38BA0", Offset = "0x2F37BA0", VA = "0x182F38BA0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2F3A530", Offset = "0x2F39530", VA = "0x182F3A530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000A")]
	public event Action OnAboveWaterEvent
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2F38B00", Offset = "0x2F37B00", VA = "0x182F38B00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2F3A490", Offset = "0x2F39490", VA = "0x182F3A490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x2F305D0", Offset = "0x2F2F5D0", VA = "0x182F305D0")]
	private void SwimmingAwake()
	{
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x2F34620", Offset = "0x2F33620", VA = "0x182F34620")]
	private void UpdateInWaterControl()
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x2F2E620", Offset = "0x2F2D620", VA = "0x182F2E620")]
	private void SetIsSwimming(bool value)
	{
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x2F2E0A0", Offset = "0x2F2D0A0", VA = "0x182F2E0A0")]
	public void RegisterEnterSwimmingReceiver(IEnterSwimmingReceiver receiver)
	{
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x2F2B170", Offset = "0x2F2A170", VA = "0x182F2B170")]
	private void DivingUnstashItems()
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x2F2B090", Offset = "0x2F2A090", VA = "0x182F2B090")]
	private void DivingStashItems()
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x2F30820", Offset = "0x2F2F820", VA = "0x182F30820")]
	private void SwimmingStashItems()
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x2F30950", Offset = "0x2F2F950", VA = "0x182F30950")]
	private void SwimmingUnstashItems()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x2F30690", Offset = "0x2F2F690", VA = "0x182F30690")]
	private bool SwimmingShouldStashItem(ItemInstance item)
	{
		return default(bool);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x2F369C0", Offset = "0x2F359C0", VA = "0x182F369C0")]
	public void UpdateUnderSurface(float distance)
	{
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x2F2BFE0", Offset = "0x2F2AFE0", VA = "0x182F2BFE0")]
	private void GetWaterLevel(out float height, out Vector3 normal, out Vector3 surfaceVel)
	{
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x2F2AD40", Offset = "0x2F29D40", VA = "0x182F2AD40")]
	private void DisableSwimming()
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x2F2ABA0", Offset = "0x2F29BA0", VA = "0x182F2ABA0")]
	private void ClearSwimmingLayerController()
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x2F367D0", Offset = "0x2F357D0", VA = "0x182F367D0")]
	private void UpdateSwimmingCameraAngleParams()
	{
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x2F2A490", Offset = "0x2F29490", VA = "0x182F2A490")]
	private void ApplySwimmingLayerController()
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x2F350B0", Offset = "0x2F340B0", VA = "0x182F350B0")]
	private void UpdateLighterInWaterControl()
	{
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x2F38460", Offset = "0x2F37460", VA = "0x182F38460")]
	public PlayerAnimatorControl()
	{
	}

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _isNetworkPlayer;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x24")]
	public float playerColliderRadius;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x28")]
	public float armMultiplyer;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody controller;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x38")]
	public playerScriptSetup setup;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x40")]
	public animEventsManager animEvents;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PlayerAAnimatorLayersController _layerController;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x50")]
	public Transform sledPivot;

	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x58")]
	public CapsuleCollider playerCollider;

	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x60")]
	public SphereCollider playerHeadCollider;

	// Token: 0x0400073B RID: 1851
	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CapsuleCollider _wallOffsetCollider;

	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _maxWallOffsetPush;

	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _wallOffsetColliderRadiusMultiplier;

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float _wallOffsetColliderRaise;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float _wallOffsetColliderLower;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _wallOffsetSpineBendMultiplier;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float _wallOffsetSpineBendAdd;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float _wallOffsetGroundSmashMultiplier;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x90")]
	public ForceLocalPosZero forcePos;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x98")]
	public wallTriggerSetup wallSetup;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject cliffCollide;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private PlayerSlideController _slideController;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("maxSpeed")]
	public float _maxInputSpeed;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0xB4")]
	public float torsoFollowSpeed;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0xB8")]
	public float _walkBlendSpeed;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0xBC")]
	public float _overallBlendSpeed;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0xC0")]
	public float storePrevYRotSpeed;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0xC4")]
	public float offsetFlintlockArmsMult;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0xC8")]
	public float offsetFlintlockHandsMult;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private float _overallSpeed;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private bool _allowSpineIk;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0xD1")]
	public bool _headLookActive;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PlayerAnimatorControl.JointWeights _lookUpWeights;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayerAnimatorControl.JointWeights _lookDownWeights;

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0xE8")]
	private float _headLookWeight;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0xEC")]
	public int combo;

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0xF0")]
	public bool lockGravity;

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0xF1")]
	public bool leftArmActive;

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0xF2")]
	public bool blockCamX;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0xF3")]
	public bool endGameCutScene;

	// Token: 0x04000759 RID: 1881
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0xF4")]
	public bool fullyAttachedToSled;

	// Token: 0x0400075A RID: 1882
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0xF5")]
	public bool useRootMotion;

	// Token: 0x0400075B RID: 1883
	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0xF6")]
	public bool useRootRotation;

	// Token: 0x0400075C RID: 1884
	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0xF7")]
	public bool doSledPushMode;

	// Token: 0x0400075D RID: 1885
	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0xF8")]
	public bool onRope;

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0xF9")]
	public bool onRopeHeightCheck;

	// Token: 0x0400075F RID: 1887
	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0xFA")]
	private bool carry;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0xFB")]
	public bool injured;

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0xFC")]
	public bool cliffClimb;

	// Token: 0x04000762 RID: 1890
	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0xFD")]
	public bool allowCliffReset;

	// Token: 0x04000763 RID: 1891
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0xFE")]
	public bool doingFullBodyAction;

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0xFF")]
	public bool sitting;

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x100")]
	public bool standingOnRaft;

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x101")]
	public bool blockInventoryOpen;

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x102")]
	public bool enteringACave;

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x103")]
	public bool holdingGlider;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x104")]
	public bool flyingGlider;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x105")]
	public bool disconnectFromGlider;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x108")]
	public float _normCamX;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x10C")]
	public float _absCamX;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x110")]
	public bool onRaft;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x111")]
	public bool introCutScene;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x112")]
	private bool _doingGroundChop;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x113")]
	public bool coldOffsetBool;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x118")]
	public float clampArmsVal;

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x11C")]
	public float wristAimOffset;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x120")]
	public bool fovAimMode;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x124")]
	public float leftArmDamp;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x128")]
	public bool onRopeWithGroundBelow;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x129")]
	public bool blockHeightCheck;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x12C")]
	public float LIFT_FORCE_MULT;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x130")]
	public float THRUST_FORCE_MULT;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x134")]
	public float OVERSHOOT_SLOWDOWN_MULT;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x138")]
	public float OVERSHOOT_MULT;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x13C")]
	public float DOWNFORCE_MULT;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x140")]
	public float MAX_GLIDER_VELOCITY;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x144")]
	public float debugLift;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x148")]
	public float debugForwardThrust;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x14C")]
	public float debugDownForce;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x150")]
	public float debugForwardMag;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x154")]
	public float debugForwardDir;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x158")]
	private bool _meleeWeaponControllerEnabled;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x159")]
	private bool _settingFullBodyWeightFromTransition;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x160")]
	private Animator _animator;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x168")]
	private Quaternion armAngle;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x178")]
	private float spineAimWeight;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x17C")]
	private Vector3 camForward;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x188")]
	private float camX;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x18C")]
	private float camYOffset;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x190")]
	private Transform closePlayer;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x198")]
	private int closePlayerCheck;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x19C")]
	private float closePlayerHeight;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x1A0")]
	private float closePlayerYVel;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x1A4")]
	private float coldOffsetTimer;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x1A8")]
	private float colliderMove;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x1AC")]
	private bool comboBlock;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x1B0")]
	public AnimatorStateInfo _playerBaseState;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x1D4")]
	public AnimatorStateInfo _playerUpperBodyState;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x1F8")]
	public bool _playerUpperBodyInTransition;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x1FC")]
	private AnimatorStateInfo currLayterState7;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x220")]
	private float currMag;

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x224")]
	private float curVel;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x228")]
	private float curVelY;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x22C")]
	private bool doFootReset;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x22D")]
	private bool _doingJumpCrouch;

	// Token: 0x0400079B RID: 1947
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x230")]
	private int fixedCount;

	// Token: 0x0400079C RID: 1948
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x234")]
	private float fovOverride;

	// Token: 0x0400079D RID: 1949
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x238")]
	private float frozenUpdateTimer;

	// Token: 0x0400079E RID: 1950
	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x23C")]
	public AnimatorStateInfo _playerFullBodyState;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x260")]
	public AnimatorStateInfo _playerLeftArmState;

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x284")]
	private Vector3 getPlayerPos;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x290")]
	private readonly float headColliderZpos;

	// Token: 0x040007A2 RID: 1954
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x294")]
	private float _horizontalMovementSpeed;

	// Token: 0x040007A3 RID: 1955
	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x298")]
	private float hVel;

	// Token: 0x040007A4 RID: 1956
	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x29C")]
	private float initialAccel;

	// Token: 0x040007A5 RID: 1957
	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x2A0")]
	private Vector3 lastPlayerPos;

	// Token: 0x040007A6 RID: 1958
	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x2AC")]
	private float lastYPos;

	// Token: 0x040007A7 RID: 1959
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x2B0")]
	private AnimatorStateInfo locoState;

	// Token: 0x040007A8 RID: 1960
	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x2D4")]
	private float lookDownBlendVal;

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x2D8")]
	private weaponInfo mainWeaponInfo;

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x2E0")]
	private float maxHeadColliderOffset;

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x2E4")]
	private Vector3 _modLocalVelVR;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x2F0")]
	private float mouseCurrentPosx;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x2F4")]
	private float mouseDeltax;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x2F8")]
	public AnimatorStateInfo _playerNextFullBodyState;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x31C")]
	public AnimatorStateInfo _playerNextLeftArmState;

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x340")]
	public AnimatorStateInfo _playerNextBaseState;

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x364")]
	public AnimatorStateInfo _playerNextUpperBodyState;

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x388")]
	private RaycastHit nHit;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x3B4")]
	private Vector3 normal1;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x3C0")]
	private Vector3 normal2;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x3CC")]
	private Vector3 normal3;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x3D8")]
	private Vector3 normal4;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x3E4")]
	private Vector3 normal5;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x3F0")]
	private readonly float offsetSpine1Amount;

	// Token: 0x040007B9 RID: 1977
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x3F4")]
	private readonly float offsetSpine2Amount;

	// Token: 0x040007BA RID: 1978
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x3F8")]
	private readonly float offsetSpine3Amount;

	// Token: 0x040007BB RID: 1979
	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x400")]
	private PlayerInventory player;

	// Token: 0x040007BC RID: 1980
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x408")]
	private float _prevCamY;

	// Token: 0x040007BD RID: 1981
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x40C")]
	private float prevMag;

	// Token: 0x040007BE RID: 1982
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x410")]
	private Vector3 prevNormal;

	// Token: 0x040007BF RID: 1983
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x420")]
	private Rigidbody rb;

	// Token: 0x040007C0 RID: 1984
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x428")]
	private playerHitReactions reactions;

	// Token: 0x040007C1 RID: 1985
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x430")]
	private Transform rootTr;

	// Token: 0x040007C2 RID: 1986
	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x438")]
	private int ropeFixDelay;

	// Token: 0x040007C3 RID: 1987
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x43C")]
	private RaycastHit ropeHit;

	// Token: 0x040007C4 RID: 1988
	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x468")]
	private bool shouldUnlockLeftHandSlot;

	// Token: 0x040007C5 RID: 1989
	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x46C")]
	private float smoothCamX;

	// Token: 0x040007C6 RID: 1990
	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x470")]
	private float _smoothCamY;

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x474")]
	private float smoothForwarDir;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x478")]
	private float startPlaneBlend;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x47C")]
	private float storeActualFovValue;

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x480")]
	private Quaternion storeLeftArmAngle;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x490")]
	private Vector3 tempPrevPos;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x49C")]
	private Vector3 tempVelocity;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x4A8")]
	private float torchCrouchOffset;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x4B0")]
	private Transform _transform;

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x4B8")]
	private float _verticalMovementSpeed;

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x4BC")]
	private float vVel;

	// Token: 0x040007D1 RID: 2001
	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x4C0")]
	private float waterBlendFloat;

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x4C4")]
	private float yVel;

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x4C8")]
	private bool _lookAtTree;

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x4CC")]
	private Vector3 _treeCorePos;

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x4D8")]
	private Dictionary<int, float> _spineBlendWeightsForItems;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x4E0")]
	private readonly ILayerBehaviourActivator[] _spineLayerActivator;

	// Token: 0x040007D7 RID: 2007
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x4E8")]
	private float _spineBlendLerpSpeed;

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x4EC")]
	private bool _spineBendEnabled;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x4F0")]
	private int _spineBlendAnimVarDisabled;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x4F4")]
	private int _useHeadWallPusher;

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x4F8")]
	private bool _disableAutoUpperBodyLayer;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x500")]
	private Coroutine _smoothResetCameraYPositionRoutine;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x508")]
	private readonly ILayerBehaviourActivator[] _deathLayerBehaviourActivators;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x510")]
	private bool _cachedDeathState;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x520")]
	private bool smoothDisableFullBodyLayer;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x524")]
	private Vector2 _lastInputMovement;

	// Token: 0x040007E2 RID: 2018
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x52C")]
	private Vector2 _currentInputMovement;

	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x538")]
	private AnimatorLayersController _layersController;

	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x540")]
	private bool _hasTriggeredSlide;

	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x544")]
	private float _terrainSlideAngle;

	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x548")]
	private bool _slidingDown;

	// Token: 0x040007E7 RID: 2023
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x549")]
	private bool _hasAlignedToGround;

	// Token: 0x040007E8 RID: 2024
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x54A")]
	private bool _doingCrouch;

	// Token: 0x040007EA RID: 2026
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x558")]
	[SerializeField]
	private GameObject _standUpInventoryWrapProp;

	// Token: 0x040007EB RID: 2027
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x560")]
	[FormerlySerializedAs("_standUpEmergencyPack")]
	[SerializeField]
	private GameObject _standUpEmergencyPackProp;

	// Token: 0x040007EC RID: 2028
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x568")]
	[SerializeField]
	private FovManager.FieldOfViewChangeSettings _standUpFromCrashFovChangeSettings;

	// Token: 0x040007ED RID: 2029
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x570")]
	private GameObject _standUpInventoryWrapPropInstance;

	// Token: 0x040007EE RID: 2030
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x578")]
	private GameObject _standUpEmergencyPackPropInstance;

	// Token: 0x040007EF RID: 2031
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x580")]
	private float _knockdownTime;

	// Token: 0x040007F0 RID: 2032
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x588")]
	private readonly ILayerBehaviourActivator[] _knockDownLayerBehaviourActivators;

	// Token: 0x040007F1 RID: 2033
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x590")]
	private readonly List<IKnockDownReceiver> _knockDownReceivers;

	// Token: 0x040007F2 RID: 2034
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x598")]
	private float _currentSledVelocity;

	// Token: 0x040007F3 RID: 2035
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x59C")]
	private float _sleddingBlendVal;

	// Token: 0x040007F4 RID: 2036
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x5A0")]
	private float _sleddingStopTimer;

	// Token: 0x040007F5 RID: 2037
	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x5A4")]
	private float _sledHorizontalVelocity;

	// Token: 0x040007F6 RID: 2038
	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x5A8")]
	private float _smoothSleddingBlend;

	// Token: 0x040007F7 RID: 2039
	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x5AC")]
	private Vector2 _originalCameraRotationRange;

	// Token: 0x040007F8 RID: 2040
	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x5B4")]
	private bool _forceStopSledding;

	// Token: 0x040007FA RID: 2042
	[Token(Token = "0x40007FA")]
	private const string SwimDiveBoolKey = "swimDiveBool";

	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	private const string SwimmingBoolKey = "swimmingBool";

	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x5B8")]
	[SerializeField]
	private GameObject _underWaterGroup;

	// Token: 0x040007FD RID: 2045
	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x5C0")]
	[SerializeField]
	private GameObject _aboveWaterGroup;

	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x5C8")]
	[SerializeField]
	[FormerlySerializedAs("swimLayerChange")]
	private bool _swimLayerChange;

	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x5C9")]
	[FormerlySerializedAs("swimming")]
	[SerializeField]
	private bool _isSwimming;

	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x5D0")]
	[SerializeField]
	private List<WaterLevelReceiverMono> _waterLevelReceivers;

	// Token: 0x04000801 RID: 2049
	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x5D8")]
	[SerializeField]
	private float _underWaterOffset;

	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x5DC")]
	[SerializeField]
	private Vector2 _waterMinHeightRange;

	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x5E8")]
	[ItemIdPicker(1, true)]
	[SerializeField]
	private List<int> _swimmingBlockStashItems;

	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x5F0")]
	private Vector3 _rootPosition;

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x5FC")]
	private float _disableSwimmingTimer;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x600")]
	private float _waterLevelCache;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x604")]
	private Vector3 _waterNormalCache;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x610")]
	private Vector3 _waterSurfaceVelocityCache;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x61C")]
	private bool _divingStashedLeft;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x61D")]
	private bool _divingStashedRight;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x61E")]
	private bool _divingStarted;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x61F")]
	private bool _swimmingStashedLeft;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x620")]
	private bool _swimmingStashedRight;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x621")]
	private bool waterBlock;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x622")]
	private bool _isUnderwater;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x623")]
	private bool _isSwimmingUnderwater;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x624")]
	private bool _wasInWater;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x625")]
	private bool _appliedSwimmingLayerController;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x628")]
	private LayerBehaviourActivator _fullBodySwimmingLayerBehaviourActivator;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x630")]
	private readonly List<IEnterSwimmingReceiver> _enterSwimmingReceivers;

	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[Serializable]
	private class JointWeights
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2F4AAE0", Offset = "0x2F49AE0", VA = "0x182F4AAE0")]
		public JointWeights()
		{
		}

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x10")]
		public float _neck0Weight;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x14")]
		public float _neck1Weight;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x18")]
		public float _head0Weight;
	}
}
