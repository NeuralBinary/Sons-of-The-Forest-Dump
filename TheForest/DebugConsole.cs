using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace TheForest
{
	// Token: 0x02000365 RID: 869
	[Token(Token = "0x2000365")]
	public class DebugConsole : MonoBehaviour
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x2C8E040", Offset = "0x2C8D040", VA = "0x182C8E040")]
		private void _aiPause(string onoff)
		{
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x2C8E670", Offset = "0x2C8D670", VA = "0x182C8E670")]
		private void _aiShowDebugCamera(string onoff)
		{
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x2C8EF40", Offset = "0x2C8DF40", VA = "0x182C8EF40")]
		private void _aiVerboseLog(string onoff)
		{
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x2C8F150", Offset = "0x2C8E150", VA = "0x182C8F150")]
		private void _aiWorldStats(string onoff)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x2C8E0F0", Offset = "0x2C8D0F0", VA = "0x182C8E0F0")]
		private void _aiPoolStats(string onoff)
		{
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x2C8F0A0", Offset = "0x2C8E0A0", VA = "0x182C8F0A0")]
		private void _aiWorldEventStats(string onoff)
		{
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x2C8F200", Offset = "0x2C8E200", VA = "0x182C8F200")]
		private void _aiZoneStats(string onoff)
		{
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x2C8EFF0", Offset = "0x2C8DFF0", VA = "0x182C8EFF0")]
		private void _aiVillageClosest(string onoff)
		{
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x2C8EE90", Offset = "0x2C8DE90", VA = "0x182C8EE90")]
		private void _aiVailStats(string onoff)
		{
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x2CA3950", Offset = "0x2CA2950", VA = "0x182CA3950")]
		private void _removeDead(string param)
		{
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x2CA3990", Offset = "0x2CA2990", VA = "0x182CA3990")]
		private void _removeLiving(string param)
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x2C93670", Offset = "0x2C92670", VA = "0x182C93670")]
		private void _damageDebug(string onoff)
		{
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x2C8DDF0", Offset = "0x2C8CDF0", VA = "0x182C8DDF0")]
		private void _aiJumpDebug(string onoff)
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x2C8DD40", Offset = "0x2C8CD40", VA = "0x182C8DD40")]
		private void _aiGodMode(string onoff)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x2C8DEA0", Offset = "0x2C8CEA0", VA = "0x182C8DEA0")]
		private void _aiKnockdownDisable(string onoff)
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x2C8DA80", Offset = "0x2C8CA80", VA = "0x182C8DA80")]
		private void _aiDodgeTest(string onoff)
		{
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x2C91F20", Offset = "0x2C90F20", VA = "0x182C91F20")]
		private void _characterLods(string onoff)
		{
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x2C8DB30", Offset = "0x2C8CB30", VA = "0x182C8DB30")]
		private void _aiDummy(string onoff)
		{
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x2C8DC90", Offset = "0x2C8CC90", VA = "0x182C8DC90")]
		private void _aiGhostPlayer(string onoff)
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x2C8DBE0", Offset = "0x2C8CBE0", VA = "0x182C8DBE0")]
		private void _aiForceStrafe(string onoff)
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x2C8E9F0", Offset = "0x2C8D9F0", VA = "0x182C8E9F0")]
		private void _aiShowPaths(string onoff)
		{
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x2C8EB90", Offset = "0x2C8DB90", VA = "0x182C8EB90")]
		private void _aiStructureLog(string onoff)
		{
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x2C8E830", Offset = "0x2C8D830", VA = "0x182C8E830")]
		private void _aiShowNavGraph(string fullParam)
		{
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x2C8D8C0", Offset = "0x2C8C8C0", VA = "0x182C8D8C0")]
		private void _aiDisable(string onoff)
		{
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x2C8F630", Offset = "0x2C8E630", VA = "0x182C8F630")]
		private void _animalsEnabled(string onoff)
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x2C8F520", Offset = "0x2C8E520", VA = "0x182C8F520")]
		private void _animalLimitMult(string param)
		{
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x2C8D690", Offset = "0x2C8C690", VA = "0x182C8D690")]
		private void _aiAnimSpeed(string param)
		{
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x2C9FAA0", Offset = "0x2C9EAA0", VA = "0x182C9FAA0")]
		private void _navGraphForceUpdate(string param)
		{
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x2C8E380", Offset = "0x2C8D380", VA = "0x182C8E380")]
		private void _aiRunWorldEvent(string param)
		{
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x2C8E720", Offset = "0x2C8D720", VA = "0x182C8E720")]
		private void _aiShowDebug(string param)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x2C82250", Offset = "0x2C81250", VA = "0x182C82250")]
		private void GetParamAndFilter(string fullParam, out string param, out string filter)
		{
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x2C8E460", Offset = "0x2C8D460", VA = "0x182C8E460")]
		private void _aiShowAnims(string paramString)
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x2C8C270", Offset = "0x2C8B270", VA = "0x182C8C270")]
		private void UpdateShowOverlay(VailOverlayType overlayType, string paramString)
		{
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x2C8EAB0", Offset = "0x2C8DAB0", VA = "0x182C8EAB0")]
		private void _aiShowStats(string paramString)
		{
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x2C8EAC0", Offset = "0x2C8DAC0", VA = "0x182C8EAC0")]
		private void _aiShowSurvivalStats(string paramString)
		{
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x2C8E820", Offset = "0x2C8D820", VA = "0x182C8E820")]
		private void _aiShowHealth(string paramString)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x2C8EAD0", Offset = "0x2C8DAD0", VA = "0x182C8EAD0")]
		private void _aiShowThoughts(string paramString)
		{
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x2C8EAA0", Offset = "0x2C8DAA0", VA = "0x182C8EAA0")]
		private void _aiShowPlayerInfluences(string paramString)
		{
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x2C8E810", Offset = "0x2C8D810", VA = "0x182C8E810")]
		private void _aiShowEventMemory(string paramString)
		{
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x2C8E1A0", Offset = "0x2C8D1A0", VA = "0x182C8E1A0")]
		private void _aiRadar(string paramString)
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x2C8D750", Offset = "0x2C8C750", VA = "0x182C8D750")]
		private void _aiArmorLevel(string param)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x2C8D810", Offset = "0x2C8C810", VA = "0x182C8D810")]
		private void _aiArmorTier(string param)
		{
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x2C8D5D0", Offset = "0x2C8C5D0", VA = "0x182C8D5D0")]
		private void _aiAngerLevel(string param)
		{
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x2C8EDE0", Offset = "0x2C8DDE0", VA = "0x182C8EDE0")]
		private void _aiThought(string param)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x2C8ED30", Offset = "0x2C8DD30", VA = "0x182C8ED30")]
		private void _aiThoughtNoCooldown(string onoff)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x2C8DF50", Offset = "0x2C8CF50", VA = "0x182C8DF50")]
		private void _aiMemoryAdjust(string param)
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x2C8EAE0", Offset = "0x2C8DAE0", VA = "0x182C8EAE0")]
		private void _aiStatAdjust(string param)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x2C8EC40", Offset = "0x2C8DC40", VA = "0x182C8EC40")]
		private void _aiTestSleep(string param)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x2C9C510", Offset = "0x2C9B510", VA = "0x182C9C510")]
		private void _killRadius(string param)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x2C81C60", Offset = "0x2C80C60", VA = "0x182C81C60")]
		private float GetFloatParam(string fullParam, int idx, float defValue = 0f)
		{
			return default(float);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x2C9B760", Offset = "0x2C9A760", VA = "0x182C9B760")]
		private void _igniteRadius(string param)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x2C95EE0", Offset = "0x2C94EE0", VA = "0x182C95EE0")]
		private void _dismemberRadius(string param)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x2C8CD80", Offset = "0x2C8BD80", VA = "0x182C8CD80")]
		private void _addVirginia(string param)
		{
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x2CACAE0", Offset = "0x2CABAE0", VA = "0x182CACAE0")]
		private void _virginiaGiveItem(int itemId)
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x2CACC50", Offset = "0x2CABC50", VA = "0x182CACC50")]
		private void _virginiaSentiment(string param)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x2CACD20", Offset = "0x2CABD20", VA = "0x182CACD20")]
		private void _virginiaVisit(string param)
		{
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x2CA4C90", Offset = "0x2CA3C90", VA = "0x182CA4C90")]
		private void _robbyCarry(string param)
		{
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x2C93170", Offset = "0x2C92170", VA = "0x182C93170")]
		private void _creepyVillage(string param)
		{
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x2C865A0", Offset = "0x2C855A0", VA = "0x182C865A0")]
		public void OnShowStatsChanged()
		{
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x2CACBA0", Offset = "0x2CABBA0", VA = "0x182CACBA0")]
		private void _virginiaInCutscenes(string arg)
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x2CA4D40", Offset = "0x2CA3D40", VA = "0x182CA4D40")]
		private void _robbyInCutscenes(string arg)
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x2C92520", Offset = "0x2C91520", VA = "0x182C92520")]
		private void _clearmidactionflag(object obj)
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x2C988B0", Offset = "0x2C978B0", VA = "0x182C988B0")]
		private void _forcePlayerExpression(string name)
		{
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x2CA13E0", Offset = "0x2CA03E0", VA = "0x182CA13E0")]
		private void _playerAnimParams(string arg)
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x2C846C0", Offset = "0x2C836C0", VA = "0x182C846C0")]
		private static void LogOutPlayerParameter(AnimatorControllerParameter param, Animator animator, StringBuilder sb)
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x2C8FE30", Offset = "0x2C8EE30", VA = "0x182C8FE30")]
		private void _audioDebug(string onOff)
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x2C88460", Offset = "0x2C87460", VA = "0x182C88460")]
		private static void SetAudioDebug(bool value)
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x2C92340", Offset = "0x2C91340", VA = "0x182C92340")]
		private void _clearAudioParameters(string audioParamPattern)
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x2C90260", Offset = "0x2C8F260", VA = "0x182C90260")]
		private void _audioParameter(string audioParamPattern)
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x2C807B0", Offset = "0x2C7F7B0", VA = "0x182C807B0")]
		private bool EventMatchesPattern(string eventName, string audioEventPattern)
		{
			return default(bool);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x2C8FD70", Offset = "0x2C8ED70", VA = "0x182C8FD70")]
		private void _audio2dTest(string arg)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x2C881D0", Offset = "0x2C871D0", VA = "0x182C881D0")]
		private void Set2dAudioTest(bool value)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x2C90580", Offset = "0x2C8F580", VA = "0x182C90580")]
		private void _audioPlayEvent(string audioEventPattern)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x2C8FEE0", Offset = "0x2C8EEE0", VA = "0x182C8FEE0")]
		private void _audioDescription(string audioEventPattern)
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x2C866A0", Offset = "0x2C856A0", VA = "0x182C866A0")]
		private void PlayAudioEvent(string eachEvent)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x2C98EC0", Offset = "0x2C97EC0", VA = "0x182C98EC0")]
		private void _freecamera(string onoff)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x2CA1820", Offset = "0x2CA0820", VA = "0x182CA1820")]
		private void _playerDebugCamera(string onoff)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x2C912A0", Offset = "0x2C902A0", VA = "0x182C912A0")]
		private void _cameraDlss(string onOff)
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x2C915F0", Offset = "0x2C905F0", VA = "0x182C915F0")]
		private void _cameraFov(string fov)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x2C83940", Offset = "0x2C82940", VA = "0x182C83940")]
		private bool HandleInput()
		{
			return default(bool);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x2C88000", Offset = "0x2C87000", VA = "0x182C88000")]
		private void SanitizeCommandInput()
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x2C83310", Offset = "0x2C82310", VA = "0x182C83310")]
		private bool HandleConsoleKeys()
		{
			return default(bool);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x2C7B9E0", Offset = "0x2C7A9E0", VA = "0x182C7B9E0")]
		private bool CheckDebugInputs()
		{
			return default(bool);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x2C7C280", Offset = "0x2C7B280", VA = "0x182C7C280")]
		private void CommandAutoComplete()
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x2C7C3F0", Offset = "0x2C7B3F0", VA = "0x182C7C3F0")]
		private void CommandHistoryForward()
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x2C7C360", Offset = "0x2C7B360", VA = "0x182C7C360")]
		private void CommandHistoryBack()
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x2C80C30", Offset = "0x2C7FC30", VA = "0x182C80C30")]
		private string FindAutoComplete(string consoleInput)
		{
			return null;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001585")]
		public static string FindAutoComplete<T>(string prefix, Dictionary<string, T> dynamicCommands)
		{
			return null;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x2C80D20", Offset = "0x2C7FD20", VA = "0x182C80D20")]
		private static string FindAutoComplete(string prefix, List<string> searchList)
		{
			return null;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x2C7AF30", Offset = "0x2C79F30", VA = "0x182C7AF30")]
		private void BuildCommandShortList()
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x2C79A90", Offset = "0x2C78A90", VA = "0x182C79A90")]
		private void Awake()
		{
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x2C857B0", Offset = "0x2C847B0", VA = "0x182C857B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x2C85700", Offset = "0x2C84700", VA = "0x182C85700")]
		private void OnDisable()
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x2C864F0", Offset = "0x2C854F0", VA = "0x182C864F0")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x2C85390", Offset = "0x2C84390", VA = "0x182C85390")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x2C8C3F0", Offset = "0x2C8B3F0", VA = "0x182C8C3F0")]
		private void Update()
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x2C85840", Offset = "0x2C84840", VA = "0x182C85840")]
		private void OnGUI()
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x2C7D700", Offset = "0x2C7C700", VA = "0x182C7D700")]
		private void DrawFramerate()
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x2C7CE80", Offset = "0x2C7BE80", VA = "0x182C7CE80")]
		private void DrawConsole(Color defaultColor)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x2C7D890", Offset = "0x2C7C890", VA = "0x182C7D890")]
		private void DrawOverlay()
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x2C81B20", Offset = "0x2C80B20", VA = "0x182C81B20")]
		private string GetDynamicResString()
		{
			return null;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x2C81A60", Offset = "0x2C80A60", VA = "0x182C81A60")]
		private string GetDynamicResScalarString()
		{
			return null;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x2C8A360", Offset = "0x2C89360", VA = "0x182C8A360")]
		private void ShowLog()
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x2C87270", Offset = "0x2C86270", VA = "0x182C87270")]
		private void RefreshLogMessages()
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x2C89BB0", Offset = "0x2C88BB0", VA = "0x182C89BB0")]
		private void ShowLegacyLog()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x2C82320", Offset = "0x2C81320", VA = "0x182C82320")]
		private Color GetTextColor(Color defaultColor, LogType logType)
		{
			return default(Color);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x2C82380", Offset = "0x2C81380", VA = "0x182C82380")]
		private static string GetTimeString()
		{
			return null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x2C8B210", Offset = "0x2C8A210", VA = "0x182C8B210")]
		private static string ToMbString(ulong bytesValue)
		{
			return null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x2C8B300", Offset = "0x2C8A300", VA = "0x182C8B300")]
		private static string ToMbString(long bytesValue)
		{
			return null;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x2C81CF0", Offset = "0x2C80CF0", VA = "0x182C81CF0")]
		public static DebugConsole GetInstance()
		{
			return null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x2C8B3D0", Offset = "0x2C8A3D0", VA = "0x182C8B3D0")]
		private void ToggleConsole()
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x2C88190", Offset = "0x2C87190", VA = "0x182C88190")]
		public void SendCommand(string command)
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x2C80960", Offset = "0x2C7F960", VA = "0x182C80960")]
		private void FinalizeConsoleInput()
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x2C88FA0", Offset = "0x2C87FA0", VA = "0x182C88FA0")]
		private void ShowConsole(bool showConsole)
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x2C8B520", Offset = "0x2C8A520", VA = "0x182C8B520")]
		private void ToggleOverlay()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x2C8B880", Offset = "0x2C8A880", VA = "0x182C8B880")]
		private void TogglePlayerStats()
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x2C8B8A0", Offset = "0x2C8A8A0", VA = "0x182C8B8A0")]
		private void ToggleVailStats()
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x2CA9D80", Offset = "0x2CA8D80", VA = "0x182CA9D80")]
		private void _spawnedObjectStats(string onoff)
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x2C8B3E0", Offset = "0x2C8A3E0", VA = "0x182C8B3E0")]
		private void ToggleGamePadWheel()
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x2C89400", Offset = "0x2C88400", VA = "0x182C89400")]
		private void ShowGamepadWheel()
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x2C7BBE0", Offset = "0x2C7ABE0", VA = "0x182C7BBE0")]
		private void CheckDisplayState()
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x2C8AFE0", Offset = "0x2C89FE0", VA = "0x182C8AFE0")]
		private IEnumerator SilentInput()
		{
			return null;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x2C78FF0", Offset = "0x2C77FF0", VA = "0x182C78FF0")]
		public static void AddCounter(Type t)
		{
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x2C87CD0", Offset = "0x2C86CD0", VA = "0x182C87CD0")]
		public static void RemoveCounter(Type t)
		{
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x2C7B700", Offset = "0x2C7A700", VA = "0x182C7B700")]
		private void CheckAmount(Type t, int amount)
		{
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x2C840B0", Offset = "0x2C830B0", VA = "0x182C840B0")]
		public void LogCallback(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x2C87ED0", Offset = "0x2C86ED0", VA = "0x182C87ED0")]
		private IEnumerator Report(string message)
		{
			return null;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x2C7C470", Offset = "0x2C7B470", VA = "0x182C7C470")]
		public UnityWebRequest CreateApiPostRequest(string actionUrl, [Optional] string body)
		{
			return null;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x2C83C20", Offset = "0x2C82C20", VA = "0x182C83C20")]
		public bool IsAlphaNum(string s)
		{
			return default(bool);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x2C82990", Offset = "0x2C81990", VA = "0x182C82990")]
		public void HandleConsoleInput(string consoleInput)
		{
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x2C844C0", Offset = "0x2C834C0", VA = "0x182C844C0")]
		private void LogCommandInfo(string message)
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x2C845C0", Offset = "0x2C835C0", VA = "0x182C845C0")]
		private void LogCommandRunning(string message)
		{
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x2C843C0", Offset = "0x2C833C0", VA = "0x182C843C0")]
		public static void LogCommandFailed(string message)
		{
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x2C80860", Offset = "0x2C7F860", VA = "0x182C80860")]
		public static void EventRegistryCleared(object eventParameter)
		{
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x2C83DA0", Offset = "0x2C82DA0", VA = "0x182C83DA0")]
		public static void LogBoltClients(string arg)
		{
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x2C7B4C0", Offset = "0x2C7A4C0", VA = "0x182C7B4C0")]
		public static void CheatsAllowedSet(object eventParameter)
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x2C791E0", Offset = "0x2C781E0", VA = "0x182C791E0")]
		public static void ApplyCommandBool(string onoff, Action<bool> applyAction, string commandString)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x2C79720", Offset = "0x2C78720", VA = "0x182C79720")]
		public static void ApplyCommandFloat(string floatString, Action<float> applyAction, Action<bool> onOffAction, string commandString)
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x2C79600", Offset = "0x2C78600", VA = "0x182C79600")]
		public static void ApplyCommandFloat(string floatString, Action<float> applyAction, string commandString)
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x2C82100", Offset = "0x2C81100", VA = "0x182C82100")]
		private static bool GetOnOffSet(string onoff, out bool onSet, out bool offSet, bool include0and1 = true)
		{
			return default(bool);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x2C79460", Offset = "0x2C78460", VA = "0x182C79460")]
		private static void ApplyCommandBool(bool onSet, Action<bool> applyAction, string commandString)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x2C79530", Offset = "0x2C78530", VA = "0x182C79530")]
		private static void ApplyCommandFloat(float floatValue, Action<float> applyAction, string commandString)
		{
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x2C9F310", Offset = "0x2C9E310", VA = "0x182C9F310")]
		private void _logging(string onoff)
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x2C9F180", Offset = "0x2C9E180", VA = "0x182C9F180")]
		private void _logShowWarnings(string onOff)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x2C9EF40", Offset = "0x2C9DF40", VA = "0x182C9EF40")]
		private void _logShowErrors(string onOff)
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x2C9F000", Offset = "0x2C9E000", VA = "0x182C9F000")]
		private void _logShowInfo(string onOff)
		{
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x2C9F0C0", Offset = "0x2C9E0C0", VA = "0x182C9F0C0")]
		private void _logShowNone(string onOff)
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x2C9B000", Offset = "0x2C9A000", VA = "0x182C9B000")]
		private void _help(object o)
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x2C92450", Offset = "0x2C91450", VA = "0x182C92450")]
		private void _clear(object o)
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x2C8B880", Offset = "0x2C8A880", VA = "0x182C8B880")]
		private void _togglePlayerStats(object o)
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x2CAB970", Offset = "0x2CAA970", VA = "0x182CAB970")]
		private void _toggleOverlay(object o)
		{
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x2CA1B40", Offset = "0x2CA0B40", VA = "0x182CA1B40")]
		private void _playerVisibility(string onoff)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x2B5E110", Offset = "0x2B5D110", VA = "0x182B5E110")]
		private void SetShowPlayerVisibility(bool value)
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x2CA8BB0", Offset = "0x2CA7BB0", VA = "0x182CA8BB0")]
		private void _showFps(string onoff)
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x2B5E140", Offset = "0x2B5D140", VA = "0x182B5E140")]
		private void SetShowFrameRate(bool value)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x2CA4130", Offset = "0x2CA3130", VA = "0x182CA4130")]
		private void _reporterrorsnow(string message)
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x2CA4770", Offset = "0x2CA3770", VA = "0x182CA4770")]
		private void _reportwarningsnow(string message)
		{
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x2CA4450", Offset = "0x2CA3450", VA = "0x182CA4450")]
		private void _reportlogsnow(string message)
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x2C92CD0", Offset = "0x2C91CD0", VA = "0x182C92CD0")]
		private void _count(string name)
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x2C92E40", Offset = "0x2C91E40", VA = "0x182C92E40")]
		private void _counttag(string name)
		{
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x2C96C50", Offset = "0x2C95C50", VA = "0x182C96C50")]
		private void _enableCheats(string toggle)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x2C88520", Offset = "0x2C87520", VA = "0x182C88520")]
		private static void SetCheatsAllowed(bool toggle)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x2CA9180", Offset = "0x2CA8180", VA = "0x182CA9180")]
		private void _showProjectileTrails(string onOff)
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x2C97470", Offset = "0x2C96470", VA = "0x182C97470")]
		private void _enablego(string name)
		{
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x2C81600", Offset = "0x2C80600", VA = "0x182C81600")]
		private static GameObject FindTest(string name)
		{
			return null;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x2CA9B50", Offset = "0x2CA8B50", VA = "0x182CA9B50")]
		private void _spawnRenderSpheres(string onoff)
		{
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x2CA3E70", Offset = "0x2CA2E70", VA = "0x182CA3E70")]
		private void _renderSpheres(string onoff)
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x2C8FAB0", Offset = "0x2C8EAB0", VA = "0x182C8FAB0")]
		private void _areaShadow(string onoff)
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x2C89340", Offset = "0x2C88340", VA = "0x182C89340")]
		private void ShowDebugRenderSpheres(bool activeValue)
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x2C89280", Offset = "0x2C88280", VA = "0x182C89280")]
		private void ShowDebugAreaShadow(bool activeValue)
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x2C952C0", Offset = "0x2C942C0", VA = "0x182C952C0")]
		private void _disableScene(string name)
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x2C96DD0", Offset = "0x2C95DD0", VA = "0x182C96DD0")]
		private void _enableScene(string name)
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x2C93B60", Offset = "0x2C92B60", VA = "0x182C93B60")]
		private void _destroyWildcard(string wildcard)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x2C95090", Offset = "0x2C94090", VA = "0x182C95090")]
		private void _disableGoWildcard(string wildcard)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x2C958C0", Offset = "0x2C948C0", VA = "0x182C958C0")]
		private void _disablego(string name)
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x2C955C0", Offset = "0x2C945C0", VA = "0x182C955C0")]
		private void _disablecomponent(string name)
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x2C97170", Offset = "0x2C96170", VA = "0x182C97170")]
		private void _enablecomponent(string name)
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x2C80EA0", Offset = "0x2C7FEA0", VA = "0x182C80EA0")]
		private static bool FindComponent(string name, int lastIndex, out string componentName, out string objectName, out GameObject go)
		{
			return default(bool);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x2C88570", Offset = "0x2C87570", VA = "0x182C88570")]
		private static bool SetComponentEnabled(GameObject go, string componentName, bool componentEnabled)
		{
			return default(bool);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x2CABC60", Offset = "0x2CAAC60", VA = "0x182CABC60")]
		private void _togglego(string name)
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x2C93D70", Offset = "0x2C92D70", VA = "0x182C93D70")]
		private void _destroy(string name)
		{
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x2C9D5D0", Offset = "0x2C9C5D0", VA = "0x182C9D5D0")]
		private void _listitems(object o)
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x2CA7020", Offset = "0x2CA6020", VA = "0x182CA7020")]
		private void _setSpeakerMode(string mode)
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x2C886D0", Offset = "0x2C876D0", VA = "0x182C886D0")]
		private static void SetSpeakerMode(SPEAKERMODE newSpeakerMode)
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x2C9DA00", Offset = "0x2C9CA00", VA = "0x182C9DA00")]
		private void _listitemswithtags(object o)
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x2C8CF30", Offset = "0x2C8BF30", VA = "0x182C8CF30")]
		private void _additem(string nameOrId)
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x2CA3B20", Offset = "0x2CA2B20", VA = "0x182CA3B20")]
		private void _removeitem(string nameOrId)
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x2C8D200", Offset = "0x2C8C200", VA = "0x182C8D200")]
		private void _additemswithtag(string tag)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x2CAA1E0", Offset = "0x2CA91E0", VA = "0x182CAA1E0")]
		private void _spawnpickup(string nameOrId)
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x2CA7940", Offset = "0x2CA6940", VA = "0x182CA7940")]
		private void _setinventorypercent(string arg)
		{
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x2C8C810", Offset = "0x2C8B810", VA = "0x182C8C810")]
		private void _addAllItems(object o)
		{
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x2CA34F0", Offset = "0x2CA24F0", VA = "0x182CA34F0")]
		private void _removeAllItems(object o)
		{
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x2C8CB80", Offset = "0x2C8BB80", VA = "0x182C8CB80")]
		private void _addAllStoryItems(object o)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x2CA3730", Offset = "0x2CA2730", VA = "0x182CA3730")]
		private void _removeAllStoryItems(object o)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x2CAC910", Offset = "0x2CAB910", VA = "0x182CAC910")]
		private void _veganmode(string onoff)
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x2C9F450", Offset = "0x2C9E450", VA = "0x182C9F450")]
		private void _loghack(string onoff)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x2C976A0", Offset = "0x2C966A0", VA = "0x182C976A0")]
		private void _energyhack(string onoff)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x2C8F3B0", Offset = "0x2C8E3B0", VA = "0x182C8F3B0")]
		private void _ammohack(string onoff)
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x2C99BA0", Offset = "0x2C98BA0", VA = "0x182C99BA0")]
		public void _godmode(string onoff)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x2C910D0", Offset = "0x2C900D0", VA = "0x182C910D0")]
		private void _buildhack(string onoff)
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x2CAA950", Offset = "0x2CA9950", VA = "0x182CAA950")]
		private void _survival(string onoff)
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x2CACE00", Offset = "0x2CABE00", VA = "0x182CACE00")]
		private void _workscheduler(string trycatch)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x2CAB760", Offset = "0x2CAA760", VA = "0x182CAB760")]
		private void _timescale(string scaleStr)
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x2C9E860", Offset = "0x2C9D860", VA = "0x182C9E860")]
		public void _lockTimeOfDay(string value)
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x2C9C1A0", Offset = "0x2C9B1A0", VA = "0x182C9C1A0")]
		private void _jumpTimeOfDay(string value)
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x2CA7270", Offset = "0x2CA6270", VA = "0x182CA7270")]
		private void _setTimeOfDay(string value)
		{
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x2C8C000", Offset = "0x2C8B000", VA = "0x182C8C000")]
		private bool TrySetTimeOfDay(string value)
		{
			return default(bool);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x2CA6030", Offset = "0x2CA5030", VA = "0x182CA6030")]
		private void _setGameTimeSpeed(string speedStr)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x2C9AE20", Offset = "0x2C99E20", VA = "0x182C9AE20")]
		private void _heallocalplayer(string amountString)
		{
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x2C9B520", Offset = "0x2C9A520", VA = "0x182C9B520")]
		private void _hitlocalplayer(string damageStr)
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x2C83B80", Offset = "0x2C82B80", VA = "0x182C83B80")]
		private static void HitLocalPlayer(int damage)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x2C9C910", Offset = "0x2C9B910", VA = "0x182C9C910")]
		private void _knockdownLocalPlayer(string param)
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x2C83D00", Offset = "0x2C82D00", VA = "0x182C83D00")]
		private static void KnockDownLocalPlayer(int damage)
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x2CA0830", Offset = "0x2C9F830", VA = "0x182CA0830")]
		private void _playDeathCutscene(string args)
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x2C9CE50", Offset = "0x2C9BE50", VA = "0x182C9CE50")]
		private void _listDeathMarkers(string args)
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x2CA0B70", Offset = "0x2C9FB70", VA = "0x182CA0B70")]
		private void _playDeathMarkerIndex(string args)
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x2CA1070", Offset = "0x2CA0070", VA = "0x182CA1070")]
		private void _playDeathMarker(string args)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x2C86DB0", Offset = "0x2C85DB0", VA = "0x182C86DB0")]
		private void PlayDrownMarker(WaterDrownMarker drownMarker)
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x2C86C20", Offset = "0x2C85C20", VA = "0x182C86C20")]
		private void PlayDeathMarker(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x2C86A70", Offset = "0x2C85A70", VA = "0x182C86A70")]
		private void PlayDeathFinal()
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x2C9C790", Offset = "0x2C9B790", VA = "0x182C9C790")]
		private void _killlocalplayer(object o)
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x2C93720", Offset = "0x2C92720", VA = "0x182C93720")]
		private void _deathCount(string value)
		{
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x2CA1280", Offset = "0x2CA0280", VA = "0x182CA1280")]
		private void _playGameOver(object o)
		{
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x2CA4AE0", Offset = "0x2CA3AE0", VA = "0x182CA4AE0")]
		private void _revivelocalplayer(object o)
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x2CA59F0", Offset = "0x2CA49F0", VA = "0x182CA59F0")]
		private void _setExitedEndGame(string param)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x2C8C640", Offset = "0x2C8B640", VA = "0x182C8C640")]
		private void _addAllBookPages(string arg)
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x2CA3460", Offset = "0x2CA2460", VA = "0x182CA3460")]
		private void _regenhealth(string arg)
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x2CA7E80", Offset = "0x2CA6E80", VA = "0x182CA7E80")]
		private void _setstat(string arg)
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x2C99850", Offset = "0x2C98850", VA = "0x182C99850")]
		private void _getGameMode(string arg)
		{
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x2CA5B60", Offset = "0x2CA4B60", VA = "0x182CA5B60")]
		private void _setGameMode(string arg)
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x2CA5780", Offset = "0x2CA4780", VA = "0x182CA5780")]
		private void _setDifficultyMode(string arg)
		{
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x2CA62D0", Offset = "0x2CA52D0", VA = "0x182CA62D0")]
		private void _setPlayerRace(string inputString)
		{
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x2C982C0", Offset = "0x2C972C0", VA = "0x182C982C0")]
		private void _follow(string arg)
		{
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x2C981E0", Offset = "0x2C971E0", VA = "0x182C981E0")]
		private void _followStop(string arg)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x2C7B310", Offset = "0x2C7A310", VA = "0x182C7B310")]
		private static void BuildGotoId(string arg, Vector3 position)
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x2C99DF0", Offset = "0x2C98DF0", VA = "0x182C99DF0")]
		private void _gotoCoords(string arg)
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x2C9A420", Offset = "0x2C99420", VA = "0x182C9A420")]
		private void _gotoforce(string arg)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x2C9D4D0", Offset = "0x2C9C4D0", VA = "0x182C9D4D0")]
		private void _listObjects(string arg)
		{
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x2C9A000", Offset = "0x2C99000", VA = "0x182C9A000")]
		private void _goto(string arg)
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x2C82770", Offset = "0x2C81770", VA = "0x182C82770")]
		private void GotoTarget(GameObject target)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x2C7BEE0", Offset = "0x2C7AEE0", VA = "0x182C7BEE0")]
		private static bool CheckForGotoPos(GameObject target, int layerMask, out RaycastHit info)
		{
			return default(bool);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x2C82650", Offset = "0x2C81650", VA = "0x182C82650")]
		private void GotoPosition(Vector3 targetPos)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x2C80F80", Offset = "0x2C7FF80", VA = "0x182C80F80")]
		private static GameObject FindObjectAdvanced(string arg, StringComparison comparisonType = 3, bool inactive = false)
		{
			return null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x2C80990", Offset = "0x2C7F990", VA = "0x182C80990")]
		private static bool FindAllObjects(string arg, out List<GameObject> allGameObjects, StringComparison comparisonType = 3, bool inactive = false)
		{
			return default(bool);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x2C84B10", Offset = "0x2C83B10", VA = "0x182C84B10")]
		private static bool MatchGameObjectName(string arg, GameObject eachGo, StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x2C81160", Offset = "0x2C80160", VA = "0x182C81160")]
		private static GameObject FindObjectIgnoreCase(string arg, bool inactive = false)
		{
			return null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x2C9A870", Offset = "0x2C99870", VA = "0x182C9A870")]
		private void _gototag(string arg)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x2CA51F0", Offset = "0x2CA41F0", VA = "0x182CA51F0")]
		private void _sendMessageTo(string arg)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x2CA2860", Offset = "0x2CA1860", VA = "0x182CA2860")]
		private void _profilersnapshot(object arg)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x2CA2470", Offset = "0x2CA1470", VA = "0x182CA2470")]
		private void _profilersample(string onoff)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x2CAC690", Offset = "0x2CAB690", VA = "0x182CAC690")]
		private void _unloadUnusedAssets(object o)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x2C97BA0", Offset = "0x2C96BA0", VA = "0x182C97BA0")]
		private void _filteraudio(string filter)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x2CAD420", Offset = "0x2CAC420", VA = "0x182CAD420")]
		private void setLastLocalTarget(Transform tr)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x2CA3350", Offset = "0x2CA2350", VA = "0x182CA3350")]
		private void _refreshEntities(string val)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x2C9CAC0", Offset = "0x2C9BAC0", VA = "0x182C9CAC0")]
		private void _listActiveEntities(string val)
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x2C921F0", Offset = "0x2C911F0", VA = "0x182C921F0")]
		private void _checkFrozenEntities(string onoff)
		{
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x2C91FD0", Offset = "0x2C90FD0", VA = "0x182C91FD0")]
		private void _checkAttachedEntities(string onoff)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x2C9AB20", Offset = "0x2C99B20", VA = "0x182C9AB20")]
		private void _greebledRocksCollision(string onoff)
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x2CAA4C0", Offset = "0x2CA94C0", VA = "0x182CAA4C0")]
		private void _speedyrun(string onoff)
		{
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x2C887C0", Offset = "0x2C877C0", VA = "0x182C887C0")]
		private void SetSpeedyRun(bool enable, float multiplier)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x2CAA7E0", Offset = "0x2CA97E0", VA = "0x182CAA7E0")]
		private void _superJump(string onoff)
		{
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x2CACD80", Offset = "0x2CABD80", VA = "0x182CACD80")]
		private void _vrFps(string onoff)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x2C92120", Offset = "0x2C91120", VA = "0x182C92120")]
		private void _checkExitMenu(string onoff)
		{
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x2CA72E0", Offset = "0x2CA62E0", VA = "0x182CA72E0")]
		private void _setWindIntensity(string val)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x2CA4A90", Offset = "0x2CA3A90", VA = "0x182CA4A90")]
		private void _resetInputAxes()
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x2CAAC20", Offset = "0x2CA9C20", VA = "0x182CAAC20")]
		private void _terrainPixelError(string val)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x2CAB980", Offset = "0x2CAA980", VA = "0x182CAB980")]
		private void _toggleVSync(string val)
		{
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x2CAB880", Offset = "0x2CAA880", VA = "0x182CAB880")]
		private void _toggleFPSDisplay(string val)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x2CAB890", Offset = "0x2CAA890", VA = "0x182CAB890")]
		private void _toggleOcclusionCulling(string val)
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x2CAAD70", Offset = "0x2CA9D70", VA = "0x182CAAD70")]
		private void _terrainRenderSimple(string onoff)
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x2CAB020", Offset = "0x2CAA020", VA = "0x182CAB020")]
		private void _terrainRender(string onoff)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x2CAAAC0", Offset = "0x2CA9AC0", VA = "0x182CAAAC0")]
		private void _targetFrameRate(string rate)
		{
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x2C9BF50", Offset = "0x2C9AF50", VA = "0x182C9BF50")]
		private void _invisible(string onoff)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x2CA1C00", Offset = "0x2CA0C00", VA = "0x182CA1C00")]
		private void _playernetanimator(string onoff)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x2C917C0", Offset = "0x2C907C0", VA = "0x182C917C0")]
		private void _capsulemode(string onoff)
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x2C88510", Offset = "0x2C87510", VA = "0x182C88510")]
		public void SetBlockConsole(bool block)
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x2C9FB40", Offset = "0x2C9EB40", VA = "0x182C9FB40")]
		private void _netAnimator(string onoff)
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x2C9FE50", Offset = "0x2C9EE50", VA = "0x182C9FE50")]
		private void _netSkinnedBones(string onoff)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x2CA0100", Offset = "0x2C9F100", VA = "0x182CA0100")]
		private void _netSpawnPlayer(string onoff)
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x2C8FB70", Offset = "0x2C8EB70", VA = "0x182C8FB70")]
		private void _astar(string onoff)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x2CAC780", Offset = "0x2CAB780", VA = "0x182CAC780")]
		private void _useRigidBodyRotation(string onoff)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x2CA5640", Offset = "0x2CA4640", VA = "0x182CA5640")]
		private void _setCurrentDay(string num)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x2C985D0", Offset = "0x2C975D0", VA = "0x182C985D0")]
		private void _forceCloud(string profile)
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x2C984F0", Offset = "0x2C974F0", VA = "0x182C984F0")]
		private void _forceCloudProfile(string profile)
		{
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x2C92600", Offset = "0x2C91600", VA = "0x182C92600")]
		private void _cloudEnable(string onOff)
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x2C92860", Offset = "0x2C91860", VA = "0x182C92860")]
		private void _cloudShadowsEnable(string onOff)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x2C92740", Offset = "0x2C91740", VA = "0x182C92740")]
		private void _cloudFactor(string coverAmount)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x2CAC6F0", Offset = "0x2CAB6F0", VA = "0x182CAC6F0")]
		private void _unlockSeason(string arg)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x2CA4F50", Offset = "0x2CA3F50", VA = "0x182CA4F50")]
		private void _season(string arg)
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x2C98A00", Offset = "0x2C97A00", VA = "0x182C98A00")]
		private void _forcerain(string arg)
		{
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x2C83B00", Offset = "0x2C82B00", VA = "0x182C83B00")]
		private static bool HasMatch(string arg, string[] offStrings)
		{
			return default(bool);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x2C9B970", Offset = "0x2C9A970", VA = "0x182C9B970")]
		private void _inspectgo(string name)
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x2C9DE40", Offset = "0x2C9CE40", VA = "0x182C9DE40")]
		private void _loadDebugConsoleMod(string filename)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x2C99960", Offset = "0x2C98960", VA = "0x182C99960")]
		private void _getlayerculldistance(string args)
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x2CA7BD0", Offset = "0x2CA6BD0", VA = "0x182CA7BD0")]
		private void _setlayerculldistance(string args)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x2CA96B0", Offset = "0x2CA86B0", VA = "0x182CA96B0")]
		private void _showworldposfor(string componentName)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x2C9B1E0", Offset = "0x2C9A1E0", VA = "0x182C9B1E0")]
		private void _hideworldposfor(string componentName)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x2CA99F0", Offset = "0x2CA89F0", VA = "0x182CA99F0")]
		private void _slapchop(string onoff)
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x2C938C0", Offset = "0x2C928C0", VA = "0x182C938C0")]
		private void _debugPlayerMelee(string param)
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x2C93810", Offset = "0x2C92810", VA = "0x182C93810")]
		private void _debugPlayerHitLog(string onoff)
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x2C924E0", Offset = "0x2C914E0", VA = "0x182C924E0")]
		private void _clearallsettings(object arg)
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x2CAB500", Offset = "0x2CAA500", VA = "0x182CAB500")]
		private void _testeventmask(object arg)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x2C960F0", Offset = "0x2C950F0", VA = "0x182C960F0")]
		private void _dumplobbyinfo(object arg)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x2C997F0", Offset = "0x2C987F0", VA = "0x182C997F0")]
		private void _gccollect(object o)
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x2C9F240", Offset = "0x2C9E240", VA = "0x182C9F240")]
		private void _logTextures(string intervalArg)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x2C8D540", Offset = "0x2C8C540", VA = "0x182C8D540")]
		private void _addmemory(string amount)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x2C93EF0", Offset = "0x2C92EF0", VA = "0x182C93EF0")]
		private void _diagRenderers(string param)
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x2C8F2B0", Offset = "0x2C8E2B0", VA = "0x182C8F2B0")]
		private void _allowAsync(string onoff)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x2C984A0", Offset = "0x2C974A0", VA = "0x182C984A0")]
		private void _footstepDebug(string param)
		{
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x2C90F30", Offset = "0x2C8FF30", VA = "0x182C90F30")]
		private void _buildermode(string onoff)
		{
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x2CABF40", Offset = "0x2CAAF40", VA = "0x182CABF40")]
		private void _trailer3(object o)
		{
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x2CABA30", Offset = "0x2CAAA30", VA = "0x182CABA30")]
		private void _toggleWorkScheduler(string param)
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x2CAD160", Offset = "0x2CAC160", VA = "0x182CAD160")]
		private void _wsscaling(string onoff)
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x2C92AE0", Offset = "0x2C91AE0", VA = "0x182C92AE0")]
		private void _countGoWithlayer(string layerName)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x2C9D240", Offset = "0x2C9C240", VA = "0x182C9D240")]
		private void _listGoWithlayer(string layerName)
		{
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x2C8BD30", Offset = "0x2C8AD30", VA = "0x182C8BD30")]
		public static bool TryRunDynamicCommand(string command, string args, DebugConsole console)
		{
			return default(bool);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x2C87AB0", Offset = "0x2C86AB0", VA = "0x182C87AB0")]
		public static void RegisterCommand(string command, Func<string, bool> commandAction, object sender)
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x2C87890", Offset = "0x2C86890", VA = "0x182C87890")]
		public static void RegisterCommand(string command, Func<string, IEnumerator> commandAction, object sender)
		{
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x2C8C160", Offset = "0x2C8B160", VA = "0x182C8C160")]
		public static void UnregisterCommand(string command, object sender)
		{
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x2C8BB10", Offset = "0x2C8AB10", VA = "0x182C8BB10")]
		private static bool TryGetDynamicCommands(string lowerCommand, out Dictionary<object, DynamicCommand> dynamicCommands)
		{
			return default(bool);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x2C877A0", Offset = "0x2C867A0", VA = "0x182C877A0")]
		public static void RegisterBoolCommand(string command, Action<bool> commandAction, object sender)
		{
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x2CAB6B0", Offset = "0x2CAA6B0", VA = "0x182CAB6B0")]
		private void _timeOfDayDebug(string arg)
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x2C90B90", Offset = "0x2C8FB90", VA = "0x182C90B90")]
		private void _billboardIgnoreChanges(string arg)
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x2CAC120", Offset = "0x2CAB120", VA = "0x182CAC120")]
		private void _treeOcclusionBonus(string arg)
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x2CA9B00", Offset = "0x2CA8B00", VA = "0x182CA9B00")]
		private void _spawnFallingTree(string arg)
		{
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x2C90830", Offset = "0x2C8F830", VA = "0x182C90830")]
		private void _billboardEnabled(string args)
		{
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x2C8F7F0", Offset = "0x2C8E7F0", VA = "0x182C8F7F0")]
		private void _anisoEnabled(string arg)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x2C8F930", Offset = "0x2C8E930", VA = "0x182C8F930")]
		private void _anisoMinMax(string arg)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x2C8BBA0", Offset = "0x2C8ABA0", VA = "0x182C8BBA0")]
		private bool TryParseMinMaxString(string argString, out float minFloat, out float maxFloat)
		{
			return default(bool);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x2CABFC0", Offset = "0x2CAAFC0", VA = "0x182CABFC0")]
		private void _treeCutSimulateBolt(string arg)
		{
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x2CAC070", Offset = "0x2CAB070", VA = "0x182CAC070")]
		private void _treeFallContactInfo(string args)
		{
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x2CA7420", Offset = "0x2CA6420", VA = "0x182CA7420")]
		private void _setWorldObjectStateRange(string args)
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x2C90CF0", Offset = "0x2C8FCF0", VA = "0x182C90CF0")]
		private void _breakObjects(string args)
		{
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x2C7C8B0", Offset = "0x2C7B8B0", VA = "0x182C7C8B0")]
		private static void CutTreesInRange(string filter, float range, out int count)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x2C7AC40", Offset = "0x2C79C40", VA = "0x182C7AC40")]
		private static void BreakObjectsInRange(string filter, float range, out int count)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x2C94470", Offset = "0x2C93470", VA = "0x182C94470")]
		private void _diggingClear(string value)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x2CAC3D0", Offset = "0x2CAB3D0", VA = "0x182CAC3D0")]
		private void _treesCutAll(string value)
		{
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x2C923A0", Offset = "0x2C913A0", VA = "0x182C923A0")]
		private void _clearBushRadius(string param)
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x2CAC1D0", Offset = "0x2CAB1D0", VA = "0x182CAC1D0")]
		private void _treeRadius(string param)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x2CACF20", Offset = "0x2CABF20", VA = "0x182CACF20")]
		private void _worldGroupId(string args)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x2CAB2A0", Offset = "0x2CAA2A0", VA = "0x182CAB2A0")]
		private void _terrainTessDist(string args)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x2C97810", Offset = "0x2C96810", VA = "0x182C97810")]
		private void _exposureSetSpeed(string args)
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x2CAB3E0", Offset = "0x2CAA3E0", VA = "0x182CAB3E0")]
		private void _terrainTess(string args)
		{
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x2CAAB20", Offset = "0x2CA9B20", VA = "0x182CAAB20")]
		private void _terrainParallax(string args)
		{
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x2C88940", Offset = "0x2C87940", VA = "0x182C88940")]
		private void SetTerrainTessValue(string args, string[] floatIds, string name, float defaultTerrainValue)
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x2CA9600", Offset = "0x2CA8600", VA = "0x182CA9600")]
		private void _showui(string onoff)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x2CA8C70", Offset = "0x2CA7C70", VA = "0x182CA8C70")]
		private void _showHud(string onoff)
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x2CA8D20", Offset = "0x2CA7D20", VA = "0x182CA8D20")]
		private void _showInWorldUi(string onoff)
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x2CA4DF0", Offset = "0x2CA3DF0", VA = "0x182CA4DF0")]
		private void _rumbleTest(string args)
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x2C87F60", Offset = "0x2C86F60", VA = "0x182C87F60")]
		private IEnumerator RumbleTestWorker()
		{
			return null;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x2C9BEA0", Offset = "0x2C9AEA0", VA = "0x182C9BEA0")]
		private void _invertLook(string param)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x2CAA730", Offset = "0x2CA9730", VA = "0x182CAA730")]
		private void _sprintToggle(string toggle)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x2C93290", Offset = "0x2C92290", VA = "0x182C93290")]
		private void _crouchToggle(string toggle)
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x2CA6180", Offset = "0x2CA5180", VA = "0x182CA6180")]
		private void _setLookRotation(string rotation)
		{
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x2C9F920", Offset = "0x2C9E920", VA = "0x182C9F920")]
		private void _mouseXSensitivity(string value)
		{
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x2C9F9E0", Offset = "0x2C9E9E0", VA = "0x182C9F9E0")]
		private void _mouseYSensitivity(string value)
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x2C99670", Offset = "0x2C98670", VA = "0x182C99670")]
		private void _gamePadXSensitivity(string value)
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x2C99730", Offset = "0x2C98730", VA = "0x182C99730")]
		private void _gamePadYSensitivity(string value)
		{
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x2C995B0", Offset = "0x2C985B0", VA = "0x182C995B0")]
		private void _gamePadDeadzone(string value)
		{
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x2C87FB0", Offset = "0x2C86FB0", VA = "0x182C87FB0")]
		private static void RunFloatMethod(string value, Action<float> action)
		{
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x2CA9E30", Offset = "0x2CA8E30", VA = "0x182CA9E30")]
		private void _spawnitem(string itemIdentifier)
		{
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x2CA2F50", Offset = "0x2CA1F50", VA = "0x182CA2F50")]
		private void _refillContainers(string args)
		{
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x2C8B050", Offset = "0x2C8A050", VA = "0x182C8B050")]
		private IEnumerator SpawnAllItems(int count)
		{
			return null;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x2C8AE30", Offset = "0x2C89E30", VA = "0x182C8AE30")]
		private void ShuffleItems(ref List<ItemData> allItemData)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x2C8B0D0", Offset = "0x2C8A0D0", VA = "0x182C8B0D0")]
		private static IEnumerator SpawnItemInternal(ItemData itemData, int count)
		{
			return null;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x2CAC4D0", Offset = "0x2CAB4D0", VA = "0x182CAC4D0")]
		private void _unloadScene(string levelArg)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x2C9E610", Offset = "0x2C9D610", VA = "0x182C9E610")]
		private void _loadSceneSingle(string levelArg)
		{
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x2C9E690", Offset = "0x2C9D690", VA = "0x182C9E690")]
		private void _loadScene(string levelArg)
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x2C7CD00", Offset = "0x2C7BD00", VA = "0x182C7CD00")]
		private bool DoUnloadScene(string levelArg)
		{
			return default(bool);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x2C7CBA0", Offset = "0x2C7BBA0", VA = "0x182C7CBA0")]
		private bool DoLoadScene(string levelArg, LoadSceneMode sceneMode)
		{
			return default(bool);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x2C93900", Offset = "0x2C92900", VA = "0x182C93900")]
		private void _demoMode(string onoff)
		{
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x2C929A0", Offset = "0x2C919A0", VA = "0x182C929A0")]
		private void _combatTestStart(string param)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x2C7B910", Offset = "0x2C7A910", VA = "0x182C7B910")]
		private void CheckAutoRunMacros(object param)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x2C9E1C0", Offset = "0x2C9D1C0", VA = "0x182C9E1C0")]
		private void _loadMacros(string param)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x2CA0360", Offset = "0x2C9F360", VA = "0x182CA0360")]
		private void _openmacrosfolder(string _)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x2C865B0", Offset = "0x2C855B0", VA = "0x182C865B0")]
		private static string[] ParseMacroLines(string[] macroLines)
		{
			return null;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x2C8C5C0", Offset = "0x2C8B5C0", VA = "0x182C8C5C0")]
		private static bool ValidMacroLine(string macroLine)
		{
			return default(bool);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x2C86650", Offset = "0x2C85650", VA = "0x182C86650")]
		private static string ParseMacroName(string macroName)
		{
			return null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x2C95A70", Offset = "0x2C94A70", VA = "0x182C95A70")]
		private void _disconnectPlayer(string arg)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x2C81710", Offset = "0x2C80710", VA = "0x182C81710")]
		private static List<BoltConnection> GetConnections(List<BoltEntity> foundPlayers)
		{
			return null;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x2C81400", Offset = "0x2C80400", VA = "0x182C81400")]
		private static List<BoltEntity> FindPlayers(string arg)
		{
			return null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x2C95CA0", Offset = "0x2C94CA0", VA = "0x182C95CA0")]
		private void _disconnectPlayers(string arg)
		{
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x2C9C2D0", Offset = "0x2C9B2D0", VA = "0x182C9C2D0")]
		private void _kickPlayers(string arg)
		{
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void _joinSteamLobby(string arg)
		{
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x2C8ABA0", Offset = "0x2C89BA0", VA = "0x182C8ABA0")]
		private void ShowVailActorOverlay(VailOverlayType value, string filter)
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x2C8ABC0", Offset = "0x2C89BC0", VA = "0x182C8ABC0")]
		private void ShowVailRadar(VailRadarType value, string filter)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x2CA94C0", Offset = "0x2CA84C0", VA = "0x182CA94C0")]
		private void _showWorldObjects(string param)
		{
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x2CA90E0", Offset = "0x2CA80E0", VA = "0x182CA90E0")]
		private void _showObjectLocation(string objectName)
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x2CA8E90", Offset = "0x2CA7E90", VA = "0x182CA8E90")]
		private void _showMeshObjectNames(string param)
		{
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x2CA8780", Offset = "0x2CA7780", VA = "0x182CA8780")]
		private void _showActiveLights(string param)
		{
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x2CA8900", Offset = "0x2CA7900", VA = "0x182CA8900")]
		private void _showCollisionObjectNames(string param)
		{
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x2CA9020", Offset = "0x2CA8020", VA = "0x182CA9020")]
		private void _showMeshTriangleCounts(string param)
		{
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x2CA8DD0", Offset = "0x2CA7DD0", VA = "0x182CA8DD0")]
		private void _showMeshMaterialNames(string param)
		{
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x2CA9400", Offset = "0x2CA8400", VA = "0x182CA9400")]
		private void _showTriggerCollision(string param)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x2CA92C0", Offset = "0x2CA82C0", VA = "0x182CA92C0")]
		private void _showStimuli(string param)
		{
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x2C83C50", Offset = "0x2C82C50", VA = "0x182C83C50")]
		private bool IsAnyWorldOverlayActive()
		{
			return default(bool);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x2C8ABE0", Offset = "0x2C89BE0", VA = "0x182C8ABE0")]
		private void ShowWorldOverlays()
		{
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x2C84DD0", Offset = "0x2C83DD0", VA = "0x182C84DD0")]
		private void OnDebugOverlayGUI()
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BC")]
		private void RefreshObjectsIfNeeded<T>(ref T[] compList, ref float refreshTime) where T : Component
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x2C860C0", Offset = "0x2C850C0", VA = "0x182C860C0")]
		private void OnMeshNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x2C85F30", Offset = "0x2C84F30", VA = "0x182C85F30")]
		private void OnLightNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x2C84C40", Offset = "0x2C83C40", VA = "0x182C84C40")]
		private void OnCollisionNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x2C8A430", Offset = "0x2C89430", VA = "0x182C8A430")]
		private void ShowRendererLabel(Renderer meshRend, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x2C88C80", Offset = "0x2C87C80", VA = "0x182C88C80")]
		private void ShowColliderLabel(Collider col, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x2C81F60", Offset = "0x2C80F60", VA = "0x182C81F60")]
		private string GetMaterialsLabel(Renderer eachMesh)
		{
			return null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x2C8A050", Offset = "0x2C89050", VA = "0x182C8A050")]
		private void ShowLightLabel(Light l, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x2C86260", Offset = "0x2C85260", VA = "0x182C86260")]
		private void OnObjectLocatorOverlayGUI(Transform target, Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x2CA0560", Offset = "0x2C9F560", VA = "0x182CA0560")]
		private void _physicsUpdateTime(string onoff)
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x2C9A9C0", Offset = "0x2C999C0", VA = "0x182C9A9C0")]
		private void _gravity(string value)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x2C96D00", Offset = "0x2C95D00", VA = "0x182C96D00")]
		private void _enableCollisionBasedKillBox(string onoff)
		{
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x2CA1EB0", Offset = "0x2CA0EB0", VA = "0x182CA1EB0")]
		private void _postProcessingComponent(string arg)
		{
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C9")]
		private static T SetVolumeComponent<T>(bool onSet) where T : VolumeComponent
		{
			return null;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x60016CA")]
		private static bool TryGetPostComponent<T>(out T result) where T : VolumeComponent
		{
			return default(bool);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x2C93B50", Offset = "0x2C92B50", VA = "0x182C93B50")]
		private void _destroyRagdoll(string onoff)
		{
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x2CA4E40", Offset = "0x2CA3E40", VA = "0x182CA4E40")]
		private void _save(string slotIndexArg)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x2C9E710", Offset = "0x2C9D710", VA = "0x182C9E710")]
		private void _load(string slotIndexArg)
		{
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x2CA4F10", Offset = "0x2CA3F10", VA = "0x182CA4F10")]
		private void _saveplayer(string arg)
		{
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x2C9E820", Offset = "0x2C9D820", VA = "0x182C9E820")]
		private void _loadplayer(string arg)
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x2C970C0", Offset = "0x2C960C0", VA = "0x182C970C0")]
		private void _enableStructureGhosts(string onoff)
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x2CA4AA0", Offset = "0x2CA3AA0", VA = "0x182CA4AA0")]
		private void _resetSettings(string args)
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x2C81D40", Offset = "0x2C80D40", VA = "0x182C81D40")]
		private bool GetKeyAndValue(string args, string cmdDebugName, out string key, out string val)
		{
			return default(bool);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x2CA6D40", Offset = "0x2CA5D40", VA = "0x182CA6D40")]
		private void _setSetting(string args)
		{
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x2CA5D50", Offset = "0x2CA4D50", VA = "0x182CA5D50")]
		private void _setGameSetupSetting(string args)
		{
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x2CA2D60", Offset = "0x2CA1D60", VA = "0x182CA2D60")]
		private void _qualityTexture(string args)
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x2C9F860", Offset = "0x2C9E860", VA = "0x182C9F860")]
		private void _mipmapStreaming(string onOff)
		{
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x2C9F6F0", Offset = "0x2C9E6F0", VA = "0x182C9F6F0")]
		private void _mipmapStreamingBudget(string value)
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x2C9F7A0", Offset = "0x2C9E7A0", VA = "0x182C9F7A0")]
		private void _mipmapStreamingDiscard(string onOff)
		{
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x2C88C50", Offset = "0x2C87C50", VA = "0x182C88C50")]
		private void SetTextureStreaming(bool value)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x2C81660", Offset = "0x2C80660", VA = "0x182C81660")]
		private void FlushStreamedMipMaps()
		{
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x2C888A0", Offset = "0x2C878A0", VA = "0x182C888A0")]
		public void SetStreamingTextureDiscardUnusedMipsOff()
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x2C888F0", Offset = "0x2C878F0", VA = "0x182C888F0")]
		private void SetStreamingTextureDiscardUnusedMips(bool value)
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x2CA6230", Offset = "0x2CA5230", VA = "0x182CA6230")]
		private void _setOpeningCrash(string arg)
		{
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x2CA2EA0", Offset = "0x2CA1EA0", VA = "0x182CA2EA0")]
		private void _radioDebug(string arg)
		{
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x2C90C40", Offset = "0x2C8FC40", VA = "0x182C90C40")]
		private void _blockPlayerFinalDeath(string arg)
		{
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x2C99500", Offset = "0x2C98500", VA = "0x182C99500")]
		private void _gameOverDelayTime(string arg)
		{
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x2C9BDC0", Offset = "0x2C9ADC0", VA = "0x182C9BDC0")]
		private void _instantRespawnHere(string param)
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x2CA1A80", Offset = "0x2CA0A80", VA = "0x182CA1A80")]
		private void _playerInterruptKeys(string arg)
		{
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x2C86F10", Offset = "0x2C85F10", VA = "0x182C86F10")]
		private void PlayerInterruptKeysOn(bool value)
		{
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x2C7C210", Offset = "0x2C7B210", VA = "0x182C7C210")]
		private IEnumerator CheckPlayerInterruptKeys()
		{
			return null;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x2C946C0", Offset = "0x2C936C0", VA = "0x182C946C0")]
		private void _disableGameObjectTester(string args)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x2C91C70", Offset = "0x2C90C70", VA = "0x182C91C70")]
		private void _caveLight(string param)
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x2CAB600", Offset = "0x2CAA600", VA = "0x182CAB600")]
		private void _timeOfDayConnectionDebug(string arg)
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x2C9EE90", Offset = "0x2C9DE90", VA = "0x182C9EE90")]
		private void _lodForce3DDistance(string arg)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x2C9EDE0", Offset = "0x2C9DDE0", VA = "0x182C9EDE0")]
		private void _lodForce2DDistance(string arg)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x2C9EA00", Offset = "0x2C9DA00", VA = "0x182C9EA00")]
		private void _lodDebugBillboards(string onOff)
		{
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x2C98950", Offset = "0x2C97950", VA = "0x182C98950")]
		private void _forceRemoveTrees(string countStr)
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x2C88680", Offset = "0x2C87680", VA = "0x182C88680")]
		private void SetDebugBillboards(bool value)
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x2C9EAC0", Offset = "0x2C9DAC0", VA = "0x182C9EAC0")]
		private void _lodDebugMaterials(string onOff)
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x2C8FA30", Offset = "0x2C8EA30", VA = "0x182C8FA30")]
		private void _applyDefaultMaterials(string onOff)
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x2C8B150", Offset = "0x2C8A150", VA = "0x182C8B150")]
		private bool StopApplyMaterial()
		{
			return default(bool);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x2C98130", Offset = "0x2C97130", VA = "0x182C98130")]
		private void _firstLookForce(string onoff)
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x2CA8850", Offset = "0x2CA7850", VA = "0x182CA8850")]
		private void _showButterflyInfo(string onOff)
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x2C96730", Offset = "0x2C95730", VA = "0x182C96730")]
		private void _dynamicResolutionCycleTest(string arg)
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x2C80760", Offset = "0x2C7F760", VA = "0x182C80760")]
		private IEnumerator DynamicResolutionTestWorker()
		{
			return null;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x2C96910", Offset = "0x2C95910", VA = "0x182C96910")]
		private void _dynamicResolutionOverride(string arg)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x2C96B20", Offset = "0x2C95B20", VA = "0x182C96B20")]
		private void _dynamicResolutionTarget(string arg)
		{
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x2C97DD0", Offset = "0x2C96DD0", VA = "0x182C97DD0")]
		private void _findObjectsWithShader(string shaderName)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x2CA39E0", Offset = "0x2CA29E0", VA = "0x182CA39E0")]
		private void _removeShader(string shaderName)
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x2CA3F30", Offset = "0x2CA2F30", VA = "0x182CA3F30")]
		private void _replaceShader(string shaderName)
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x2C799F0", Offset = "0x2C789F0", VA = "0x182C799F0")]
		private IEnumerator ApplyShaderToMaterialsWorker(string shaderPath, bool addRandomColor)
		{
			return null;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x2C9EB70", Offset = "0x2C9DB70", VA = "0x182C9EB70")]
		private void _lodDebugRanges(string lodType)
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x2C92F40", Offset = "0x2C91F40", VA = "0x182C92F40")]
		private void _createLight(string args)
		{
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x2C962D0", Offset = "0x2C952D0", VA = "0x182C962D0")]
		private void _duplicateObject(string args)
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x2CA64A0", Offset = "0x2CA54A0", VA = "0x182CA64A0")]
		private void _setProperty(string args)
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x2C87060", Offset = "0x2C86060", VA = "0x182C87060")]
		private static string[] ProcessArgs(string args)
		{
			return null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x2C7C590", Offset = "0x2C7B590", VA = "0x182C7C590")]
		private GameObject CreateCaveLight()
		{
			return null;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x2C93340", Offset = "0x2C92340", VA = "0x182C93340")]
		public DebugConsole()
		{
		}

		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		private const int TrackSuitId = 555;

		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		private const int DressId = 556;

		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		private const int LeatherSuitId = 557;

		// Token: 0x040015CD RID: 5581
		[Token(Token = "0x40015CD")]
		private const int CamoSuitId = 558;

		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _debugAudioEvent;

		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x28")]
		private List<string[]> _audioParameters;

		// Token: 0x040015D0 RID: 5584
		[Token(Token = "0x40015D0")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _2dAudioTestListener;

		// Token: 0x040015D1 RID: 5585
		[Token(Token = "0x40015D1")]
		[FieldOffset(Offset = "0x38")]
		private float _defaultFov;

		// Token: 0x040015D2 RID: 5586
		[Token(Token = "0x40015D2")]
		private const string RegexWhiteSpace = "\\s";

		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		[FieldOffset(Offset = "0x3C")]
		private int _historyEnd;

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x40")]
		private int _historyCurrent;

		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		[FieldOffset(Offset = "0x48")]
		private string _consoleInput;

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x50")]
		private string _autocomplete;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x58")]
		public bool _showOverlay;

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x59")]
		public bool _showLog;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _logCanvas;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _logMessage;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> _logMessageInstances;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x78")]
		public bool _showConsole;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x79")]
		public bool _showGamePadWheel;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x7A")]
		public bool _showPlayerStats;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x7B")]
		public bool _showFramerate;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x7C")]
		public bool _showPlayerVisibility;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x80")]
		public GUIStyle _consoleRowStyle;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x88")]
		public GUIStyle _logRowStyle;

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x90")]
		public GUIStyle _textStyle;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _activateObjects;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _warningTextColor;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _errorTextColor;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Color _exceptionTextColor;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0xD0")]
		[Multiline]
		public string _reportFormat;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0xD8")]
		private string _reportFormatNew;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0xE0")]
		public string _reportUrl;

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x0")]
		public static int BatchedTasksNear;

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		[FieldOffset(Offset = "0x4")]
		public static int BatchedTasksFar;

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0xE8")]
		private Queue<LogContent> _logs;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0xF0")]
		private LogContent _lastLog;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0xF8")]
		private DebugConsoleRoutine _routineMB;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x100")]
		private Coroutine _inputRoutine;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x108")]
		private bool _destroyOnTitleSceneLoad;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x10C")]
		private int _maxLogs;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x110")]
		private Vector2 _logsScrollPos;

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x118")]
		private string[] _history;

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[FieldOffset(Offset = "0x120")]
		private char[] _alphaNum;

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x128")]
		private float _fps;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x12C")]
		private bool _showWSDetail;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x12D")]
		private bool _focusConsoleField;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x12E")]
		private bool _selectConsoleText;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<string, MethodInfo> _availableConsoleMethods;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<Type, int> _counters;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<string, string> _gamepadWheelEntries;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, int> Counters;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x10")]
		private static DebugConsole Instance;

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x148")]
		private Transform lastLocalTarget;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0x150")]
		private int _totalEntities;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x154")]
		private int _activeEntities;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x158")]
		private int _overlayState;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x160")]
		private VisualWorldDebugGrid _visualWorldDebugGrid;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x168")]
		private bool _showWarnSetting;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x169")]
		private bool _showInfoSetting;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x16A")]
		private bool _showErrorSetting;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x16C")]
		private int _logCallbackCount;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x170")]
		private int _lastLogCallbackCountHandled;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x178")]
		private List<string> _commandShortList;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x180")]
		private bool _blockConsole;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x188")]
		private List<GameObject> _disabledGOs;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x190")]
		private bool _speedyRunIsActive;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x194")]
		private float _speedyRunMultipler;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x198")]
		private Coroutine _followCoroutine;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x1A0")]
		private GUIStyle _style;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x1A8")]
		private Dictionary<string, Vector3> _loadedGotos;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector3 _defaultGravity;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x1BC")]
		private bool _cursorAtEndConsoleInput;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x1C0")]
		private Material _terrainDefaultMaterial;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x1C8")]
		private Material _terrainSimpleMaterial;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x1D0")]
		private float wsMaxMsValue;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Dictionary<object, DynamicCommand>> _dynamicCommands;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x1D4")]
		private int _defaultTerrainTess;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x1D8")]
		private float _defaultTerrainTessDist;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x20")]
		private static string _macrosDir;

		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		private const string AutoRunMacroSettingKey = "AutoRunMacro";

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x1DC")]
		private float _showMeshOverlayDist;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x1E0")]
		private float _showMeshMinSize;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x1E8")]
		private string _showMeshFilter;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x1F0")]
		private bool _showMeshMaterials;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x1F1")]
		private bool _showMeshTriCount;

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x1F2")]
		private bool _showTriggerCollisionOn;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x1F8")]
		private Renderer[] _meshes;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x200")]
		private float _refreshMeshTime;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x204")]
		private float _showColliderOverlayDist;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x208")]
		private string _showCollisionFilter;

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x210")]
		private Collider[] _colliders;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x218")]
		private float _refreshColliderTime;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x21C")]
		private bool _showCollisionLayers;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x21D")]
		private bool _showCollisionTags;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x21E")]
		private bool _showLightsOverlay;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x220")]
		private float _refreshLightTime;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x228")]
		private Light[] _lights;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x230")]
		private GameObject _objectLocationTarget;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x238")]
		private int _showStimuliDist;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x240")]
		private string _stimuliTypeFilter;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x248")]
		private VailOverlayType _showVailActorOverlay;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x250")]
		private string _showVailOverlayTypeFilter;

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x258")]
		private VailRadarType _showVailRadar;

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x260")]
		private string _radarTypeFilter;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0x268")]
		private int _showWorldObjectOverlayDist;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x270")]
		private string _worldObjectFilter;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x278")]
		private float _defaultFixedDeltaTime;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x280")]
		private Coroutine _dynamicResolutionTestWorker;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x288")]
		private GameObject _caveLightGo;

		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int BaseColorIndex;

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[FieldOffset(Offset = "0x290")]
		private Coroutine _applyMaterialsWorker;

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x298")]
		private string _replaceShaderString;

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x2A0")]
		private List<Shader> _replacedShaders;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x2A8")]
		private int _spawnedLights;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x2AC")]
		private bool _playerInterruptKeysOn;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x2B0")]
		private Coroutine _checkPlayerInterruptKeysRoutine;

		// Token: 0x02000366 RID: 870
		[Token(Token = "0x2000366")]
		internal class DebugConsoleMacro
		{
			// Token: 0x06001709 RID: 5897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x87BC70", Offset = "0x87AC70", VA = "0x18087BC70")]
			internal DebugConsoleMacro(string name, string[] commands)
			{
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x2CAF1F0", Offset = "0x2CAE1F0", VA = "0x182CAF1F0")]
			public IEnumerator Execute(string param)
			{
				return null;
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x00007080 File Offset: 0x00005280
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x2CAF2F0", Offset = "0x2CAE2F0", VA = "0x182CAF2F0")]
			private bool TryGetSleepTimer(string command, out float result)
			{
				return default(bool);
			}

			// Token: 0x0600170C RID: 5900 RVA: 0x00007098 File Offset: 0x00005298
			[Token(Token = "0x600170C")]
			[Address(RVA = "0x2CAF260", Offset = "0x2CAE260", VA = "0x182CAF260")]
			private static bool ProcessFloatParts(out float result, string integer, string decimalPoint, string remainder)
			{
				return default(bool);
			}

			// Token: 0x0400163F RID: 5695
			[Token(Token = "0x400163F")]
			[FieldOffset(Offset = "0x10")]
			private string _name;

			// Token: 0x04001640 RID: 5696
			[Token(Token = "0x4001640")]
			[FieldOffset(Offset = "0x18")]
			private string[] _commands;
		}
	}
}
