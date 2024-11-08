/**
 * @param { import("knex").Knex } knex
 * @returns { Promise<void> } 
 */
exports.seed = async function(knex) {
  await knex('RECENTFOOD').del(); // Deletes ALL existing 
  await knex.raw("DBCC CHECKIDENT ('RECENTFOOD', RESEED, 0)");
  await knex('RECENTFOOD').insert([{ FOODID: 1 },]);
  await knex('RECENTFOOD').insert([{ FOODID: 14 },]);
  await knex('RECENTFOOD').insert([{ FOODID: 8 },]);
  await knex('RECENTFOOD').insert([{ FOODID: 4 },]);
  await knex('RECENTFOOD').insert([{ FOODID: 7 },]);
  await knex('RECENTFOOD').insert([{ FOODID: 3 },]);
};