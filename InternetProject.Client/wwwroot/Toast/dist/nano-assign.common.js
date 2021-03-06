/*!
 * nano-assign v1.0.0
 * (c) 2017-present egoist <0x142857@gmail.com>
 * Released under the MIT License.
 */
'use strict';

var index = function(obj) {
  var arguments$1 = arguments;

  for (var i = 1; i < arguments.length; i++) {
    // eslint-disable-next-line guard-for-in, prefer-rest-params
    for (var p in arguments[i]) { obj[p] = arguments$1[i][p]; }
  }
  return obj
};

module.exports = index;
