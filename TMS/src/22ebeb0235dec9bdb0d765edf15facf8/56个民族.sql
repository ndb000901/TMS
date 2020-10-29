/*
 Navicat Premium Data Transfer

 Target Server Type    : MySQL
 Target Server Version : 80015
 File Encoding         : 65001

 Date: 12/02/2019 17:54:47
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_minzu
-- ----------------------------
DROP TABLE IF EXISTS `t_minzu`;
CREATE TABLE `t_minzu`  (
  `Id` tinyint(3) UNSIGNED NOT NULL,
  `Cn` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '' COMMENT '民族',
  `Py` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '' COMMENT '拼音',
  `En` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '' COMMENT '英文名',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_minzu
-- ----------------------------
INSERT INTO `t_minzu` VALUES
(1, '汉族', 'Han zu', 'Han'),
(2, '蒙古族', 'Menggu zu', 'Mongol'),
(3, '回族', 'Hui zu', 'Hui'),
(4, '藏族', 'Zang zu', 'Tibetan'),
(5, '维吾尔族', 'WeiWu\'er zu', 'Uighur'),
(6, '苗族', 'Miao zu', 'Hmong'),
(7, '彝族', 'Yi zu', 'Yi'),
(8, '壮族', 'Zhuang zu', 'Bourau'),
(9, '布依族', 'Buyi zu', 'Buyi'),
(10, '朝鲜族', 'Chaoxian zu', 'Korean'),
(11, '满族', 'Man zu', 'Manchu'),
(12, '侗族', 'Dong zu', 'Dong'),
(13, '瑶族', 'Yao zu', 'Yao'),
(14, '白族', 'Bai zu', 'Bai'),
(15, '土家族', 'Tujia zu', 'Tujia'),
(16, '哈尼族', 'Hani zu', 'Hani'),
(17, '哈萨克族', 'HaSake zu', 'Kazakh'),
(18, '傣族', 'Dai zu', 'Dai'),
(19, '黎族', 'Li zu', 'Li'),
(20, '傈僳族', 'Lisu zu', 'Lisu'),
(21, '佤族', 'Wa zu', 'Wa'),
(22, '畲族', 'She zu', 'She'),
(23, '高山族', 'Gaoshan zu', 'Gaoshan'),
(24, '拉祜族', 'Lahu zu', 'Lahu'),
(25, '水族', 'Shui zu', 'Shui'),
(26, '东乡族', 'Dongxiang zu', 'Dongxiang'),
(27, '纳西族(包括摩梭)', 'Naxi zu', 'Naxi (inc Mosuo)'),
(28, '景颇族', 'Jingpo zu', 'Jingpo'),
(29, '柯尔克孜族', 'Ke\'ErKezi zu', 'Kirgiz'),
(30, '土族', 'Tu zu', 'Tu'),
(31, '达斡尔族', 'DaWo\'er zu', 'Daur'),
(32, '仫佬族', 'Mulao zu', 'Mulam'),
(33, '羌族', 'Qiang zu', 'Chiang'),
(34, '布朗族', 'Bulang zu', 'Blang'),
(35, '撒拉族', 'Sala zu', 'Salar'),
(36, '毛南族', 'Maonan zu', 'Maonan'),
(37, '仡佬族', 'Gelao zu', 'Gelao'),
(38, '锡伯族', 'Xibo zu', 'Xibe'),
(39, '阿昌族', 'Achang zu', 'Achang'),
(40, '普米族', 'Pumi zu', 'Pumi'),
(41, '塔吉克族', 'TaJike zu', 'Tajik'),
(42, '怒族', 'Nu zu', 'Nu'),
(43, '乌孜别克族', 'WuZiBieke zu', 'Uzbek'),
(44, '俄罗斯族', 'ELuosi zu', 'Russian'),
(45, '鄂温克族', 'EWenke zu', 'Evenki'),
(46, '德昂族(崩龙族)', 'De\'ang zu', 'De\'ang'),
(47, '保安族', 'Bao\'an zu', 'Bonan'),
(48, '裕固族', 'Yugu zu', 'Yugur'),
(49, '京族', 'Jing zu', 'Gin'),
(50, '塔塔尔族', 'TaTa\'er zu', 'Tatar'),
(51, '独龙族', 'Dulong zu', 'Drung'),
(52, '鄂伦春族', 'ELunchun zu', 'Oroqin'),
(53, '赫哲族', 'Hezhe zu', 'Hezhen'),
(54, '门巴族', 'Menba zu', 'Menba'),
(55, '珞巴族', 'Luoba zu', 'Lhoba'),
(56, '基诺族', 'Jinuo zu', 'Jino'),
(97, '其他', 'Qita', 'Other');

SET FOREIGN_KEY_CHECKS = 1;
